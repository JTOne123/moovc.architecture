namespace MooVC.Architecture.Ddd.DomainEventTests
{
    using System;
    using MooVC.Architecture.MessageTests;
    using Xunit;

    public sealed class WhenDomainEventIsConstructed
    {
        [Theory]
        [InlineData(1)]
        [InlineData(18446744073709551615)]
        public void GivenAContextAndAnAggregateReferenceThenTheContextAndAggregateReferenceArePropagated(ulong expectedVersion)
        {
            var expectedId = Guid.NewGuid();
            var expectedAggregate = new VersionedReference<AggregateRoot>(expectedId, version: expectedVersion);
            var expectedContext = new SerializableMessage();

            var @event = new SerializableDomainEvent(expectedContext, expectedAggregate);
            
            Assert.Equal(expectedAggregate, @event.Aggregate);
            Assert.Equal(expectedContext.Id, @event.CausationId);
            Assert.Equal(expectedContext.CorrelationId, @event.CorrelationId);
        }
        
        [Fact]
        public void GivenNoContextAndAnAggregateReferenceThenAnArgumentNullExceptionIsThrown()
        {
            var id = Guid.NewGuid();
            var aggregate = new VersionedReference<AggregateRoot>(id);

            _ = Assert.Throws<ArgumentNullException>(
                () => new SerializableDomainEvent(null, aggregate));
        }
    }
}