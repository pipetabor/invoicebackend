using Invoice.Backend.Shared.Entities;

namespace Invoice.Backend.Shared.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task DispatchAndClearEvents(IEnumerable<EntityBase> entitiesWithEvents);
    }
}
