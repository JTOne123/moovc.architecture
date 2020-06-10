﻿namespace MooVC.Architecture.Ddd.Services.Snapshots.DefaultSnapshotProviderTests
{
    using System;
    using MooVC.Architecture.Ddd.Services.Reconciliation;
    using MooVC.Persistence;
    using Moq;
    using Xunit;

    public sealed class WhenDefaultSnapshotProviderIsConstructed
    {
        private readonly Mock<IAggregateReconciliationProxy> proxy;
        private readonly Mock<IEventStore<ISequencedEvents, ulong>> store;

        public WhenDefaultSnapshotProviderIsConstructed()
        {
            proxy = new Mock<IAggregateReconciliationProxy>();
            store = new Mock<IEventStore<ISequencedEvents, ulong>>();
        }

        [Fact]
        public void GivenAnEventStoreAndAFactoryThenAnInstanceIsCreated()
        {
            _ = new DefaultSnapshotProvider(store.Object, () => type => proxy.Object);
        }

        [Fact]
        public void GivenAnEventStoreAndANullFactoryThenAnArgumentNullExceptionIsThrown()
        {
            _ = Assert.Throws<ArgumentNullException>(
                () => new DefaultSnapshotProvider(store.Object, default));
        }

        [Fact]
        public void GivenAFactoryAndANullEventStoreThenAnArgumentNullExceptionIsThrown()
        {
            _ = Assert.Throws<ArgumentNullException>(
                () => new DefaultSnapshotProvider(default, () => type => proxy.Object));
        }
    }
}