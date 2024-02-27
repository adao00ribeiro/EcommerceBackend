using Ecommerce.Api.Entities.Shared;

namespace Ecommerce.Api.Interfaces.Repositories.Shared;

public interface IRepositoryBase<TEntity> : IDisposable where TEntity : Entity
{
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<TEntity?> GetByIdAsync(int id);
    Task<int> AddAsync(TEntity objeto);
    Task UpdateAsync(TEntity objeto);
    Task RemoveAsync(TEntity objeto);
    Task RemoveByIdAsync(int id);
}
