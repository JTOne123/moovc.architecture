namespace MooVC.Architecture.Ddd.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using static MooVC.Ensure;
    using static Resources;

    public sealed class DomainEventPropagator<TAggregate>
        where TAggregate : EventCentricAggregateRoot
    {
        private readonly IBus bus;
        private readonly IRepository<TAggregate> repository;

        public DomainEventPropagator(IBus bus, IRepository<TAggregate> repository)
        {
            ArgumentNotNull(bus, nameof(bus), DomainEventPropagatorBusRequired);
            ArgumentNotNull(repository, nameof(repository), DomainEventPropagatorRepositoryRequired);

            this.bus = bus;
            this.repository = repository;
            this.repository.AggregateSaved += Repository_AggregateSaved;
        }

        private void Repository_AggregateSaved(IRepository<TAggregate> sender, AggregateSavedEventArgs<TAggregate> e)
        {
            IEnumerable<DomainEvent> changes = e.Aggregate.GetUncommittedChanges();

            bus.Publish(changes.ToArray());
        }
    }
}