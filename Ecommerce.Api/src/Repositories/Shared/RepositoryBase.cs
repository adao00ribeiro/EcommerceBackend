using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await Context.Set<TEntity>()
       .AsNoTracking()
       .ToListAsync();
    }
    public virtual async Task<TEntity?> GetByIdAsync(int id) =>
        await Context.Set<TEntity>().FindAsync(id);

    public virtual async Task<int> AddAsync(TEntity objeto)
    {
        Context.Add(objeto);
        await Context.SaveChangesAsync();
        return objeto.Id;
    }

    public virtual async Task UpdateAsync(TEntity objeto)
    {
        Context.Entry(objeto).State = EntityState.Modified;
        await Context.SaveChangesAsync();
    }

    public virtual async Task RemoveAsync(TEntity objeto)
    {
        Context.Set<TEntity>().Remove(objeto);
        await Context.SaveChangesAsync();
    }

    public virtual async Task RemoveByIdAsync(int id)
    {
        var objeto = await GetByIdAsync(id);
        if (objeto == null)
            throw new Exception("O registro não existe na base de dados.");
        await RemoveAsync(objeto);
    }

    public void Dispose() =>
        Context.Dispose();


}