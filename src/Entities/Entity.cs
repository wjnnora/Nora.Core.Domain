namespace Nora.Core.Domain.Entities;

public abstract class Entity<TId>
{
    public TId Id { get; protected set; }
    public DateTime CreatedAt { get; protected set; }

    protected Entity()
    {
        CreatedAt = DateTime.Now;
    }
}