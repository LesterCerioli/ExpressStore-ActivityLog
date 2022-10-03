namespace ExpressStore.Infrastructure.Models
{
    public abstract class EntityBaseWithTypedId<TId> : ValidatableObject, IEntityWithTypedid<TId>
    {
        public virtual TId Id {get; protected set; }
        
    }
}