using System.Linq.Expressions;
using Ecommerce.Api.src.Context;
using Ecommerce.Api.src.Entities.Shared;
using Ecommerce.Api.src.Interfaces.Repositories.Shared;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Api.src.Repositories.Shared;

public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : Entity
{
    protected readonly DataContext Context;
    public RepositoryBase(DataContext dataContext) =>
    Context = dataContext;
    public virtual async Task<IEnumerable<TEntity>> GetAllAsync(params Expression<Func<TEntity, object>>[] includeProperties)
    {

        IQueryable<TEntity> query = Context.Set<TEntity>().AsNoTracking();

        foreach (var includeProperty in includeProperties)
        {
            query = query.Include(includeProperty);
        }

        return await query.ToListAsync();

    }
    public virtual async Task<TEntity?> GetByIdAsync(string id) =>
        await Context.Set<TEntity>().FindAsync(id);

    public virtual async Task<string> AddAsync(TEntity objeto)
    {
        Context.Add(objeto);
        await Context.SaveChangesAsync();
        return objeto.Id;
    }

    public virtual async Task UpdateAsync(TEntity objeto)
    {
        var objetUpdate = await GetByIdAsync(objeto.Id);
        if (objetUpdate == null)
            throw new Exception("O registro não existe na base de dados.");
        foreach (var prop in objeto.GetType().GetProperties())
        {
            var entityProp = typeof(TEntity).GetProperty(prop.Name);
            if (entityProp != null)
            {
                entityProp.SetValue(objetUpdate, prop.GetValue(objeto));
            }
        }
        Context.Entry(objetUpdate).State = EntityState.Modified;
        await Context.SaveChangesAsync();
    }

    public virtual async Task RemoveAsync(TEntity objeto)
    {
        Context.Set<TEntity>().Remove(objeto);
        await Context.SaveChangesAsync();
    }

    public virtual async Task RemoveByIdAsync(string id)
    {
        var objeto = await GetByIdAsync(id);
        if (objeto == null)
            throw new Exception("O registro não existe na base de dados.");
        await RemoveAsync(objeto);
    }

    public void Dispose() =>
        Context.Dispose();


}