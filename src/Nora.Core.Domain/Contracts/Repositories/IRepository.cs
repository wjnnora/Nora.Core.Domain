using Nora.Core.Domain.Entities;

namespace Nora.Core.Domain.Contracts.Repositories;

public interface IRepository<TEntity, TKey> : 
    IWriteOnlyRepository<TEntity, TKey>, 
    IReadOnlyRepository<TEntity, TKey>
    where TEntity : Entity<TKey>;