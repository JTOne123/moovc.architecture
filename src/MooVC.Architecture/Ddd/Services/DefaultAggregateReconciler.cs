﻿namespace MooVC.Architecture.Ddd.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using MooVC.Architecture.Ddd;
    using MooVC.Linq;
    using static MooVC.Ensure;
    using static Resources;

    public sealed class DefaultAggregateReconciler
        : AggregateReconciler
    {
        private readonly Func<Type, IAggregateReconciliationProxy> factory;
        private readonly bool ignorePreviousVersions;
        private readonly TimeSpan? timeout;

        public DefaultAggregateReconciler(
            Func<Type, IAggregateReconciliationProxy> factory,
            bool ignorePreviousVersions = true,
            TimeSpan? timeout = default)
        {
            ArgumentNotNull(factory, nameof(factory), AggregateReconcilerFactoryRequired);

            this.factory = factory;
            this.ignorePreviousVersions = ignorePreviousVersions;
            this.timeout = timeout;
        }

        public override void Reconcile(IEnumerable<DomainEvent> events)
        {
            if (events.SafeAny())
            {
                foreach (IGrouping<VersionedReference, DomainEvent> aggregateEvents in events.GroupBy(@event => @event.Aggregate))
                {
                    IAggregateReconciliationProxy proxy = factory(aggregateEvents.Key.Type);

                    if (proxy is null)
                    {
                        OnUnsupportedAggregateDetected(aggregateEvents.Key, aggregateEvents);
                    }
                    else if (EventsAreNonConflicting(aggregateEvents.Key, aggregateEvents, out _))
                    {
                        Reconcile(aggregateEvents.Key, aggregateEvents, proxy);
                    }
                }
            }
        }

        private void PerformCoordinatedReconcile(
           Reference aggregate,
           IEnumerable<DomainEvent> events,
           IAggregateReconciliationProxy proxy)
        {
            EventCentricAggregateRoot existing = proxy.Get(aggregate);

            if (existing is null)
            {
                existing = proxy.Create(aggregate);
            }
            else if (ignorePreviousVersions)
            {
                events = RemovePreviousVersions(events, existing.Version);
            }

            Apply(existing, events, proxy, aggregate);
        }

        private void Reconcile(
            Reference aggregate,
            IEnumerable<DomainEvent> events,
            IAggregateReconciliationProxy proxy)
        {
            aggregate.Coordinate(
                () => PerformCoordinatedReconcile(aggregate, events, proxy),
                timeout: timeout);
        }
    }
}