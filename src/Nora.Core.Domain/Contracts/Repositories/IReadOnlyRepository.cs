using Nora.Core.Domain.Entities;

namespace Nora.Core.Domain.Contracts.Repositories;

public interface IReadOnlyRepository<TEntity, in TKey> where TEntity : Entity<TKey>
{
    Task<TEntity> GetByIdAsync(TKey id);
}