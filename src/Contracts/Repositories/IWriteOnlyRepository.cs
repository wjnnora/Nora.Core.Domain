using Nora.Core.Domain.Entities;

namespace Nora.Core.Domain.Contracts.Repositories;

public interface IWriteOnlyRepository<in TEntity, in TKey> where TEntity : Entity<TKey>
{
    Task AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteByIdAsync(TKey id);
}