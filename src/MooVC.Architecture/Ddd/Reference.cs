namespace MooVC.Architecture.Ddd
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class Reference
        : Value
    {
        private protected Reference(Guid id)
        {
            Id = id;
        }

        private protected Reference(AggregateRoot aggregate)
        {
            Id = aggregate.Id;
        }

        protected Reference(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            Id = (Guid)info.GetValue(nameof(Id), typeof(Guid));
        }

        public Guid Id { get; }

        public bool IsEmpty => Id == Guid.Empty;

        public abstract Type Type { get; }

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            info.AddValue(nameof(Id), Id);
        }

        public virtual bool IsMatch(AggregateRoot aggregate)
        {
            return Type == aggregate?.GetType()
                ? Id == aggregate.Id
                : false;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Id;
            yield return Type;
        }
    }
}