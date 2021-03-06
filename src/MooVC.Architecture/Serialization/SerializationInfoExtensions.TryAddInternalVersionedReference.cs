﻿namespace MooVC.Architecture.Serialization
{
    using System.Runtime.Serialization;
    using MooVC.Architecture.Ddd;
    using MooVC.Serialization;

    public static partial class SerializationInfoExtensions
    {
        public static bool TryAddInternalVersionedReference<TAggregate>(this SerializationInfo info, string name, VersionedReference<TAggregate> reference)
            where TAggregate : AggregateRoot
        {
            return info.TryAddInternalValue(name, reference, predicate: _ => reference is { } && !reference.IsEmpty);
        }
    }
}