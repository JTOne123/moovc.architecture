namespace MooVC.Architecture.Ddd.EventCentricAggregateRootTests
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    internal sealed class SerializableCreatedDomainEvent
        : DomainEvent
    {
        public SerializableCreatedDomainEvent(Message context, SerializableEventCentricAggregateRoot aggregate)
            : base(context, aggregate.ToVersionedReference())
        {
        }

        public SerializableCreatedDomainEvent(Message context, VersionedReference aggregate)
            : base(context, aggregate)
        {
        }

        private SerializableCreatedDomainEvent(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}