using System.Linq.Expressions;
using Ecommerce.Api.src.Entities.Shared;

namespace Ecommerce.Api.src.Interfaces.Repositories.Shared;

public interface IRepositoryBase<TEntity> : IDisposable where TEntity : Entity
{
    Task<IEnumerable<TEntity>> GetAllAsync(params Expression<Func<TEntity, object>>[] includeProperties);
    Task<TEntity?> GetByIdAsync(string id);
    Task<string> AddAsync(TEntity objeto);
    Task UpdateAsync(TEntity objeto);
    Task RemoveAsync(TEntity objeto);
    Task RemoveByIdAsync(string id);
}
