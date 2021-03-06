namespace MooVC.Architecture.Ddd
{
    using static Ensure;

    public static partial class ReferenceExtensions
    {
        public static Reference<TAggregate> ToTypedReference<TAggregate>(this Reference reference)
            where TAggregate : AggregateRoot
        {
            ReferenceIsOfType<TAggregate>(reference, nameof(reference));

            return reference is Reference<TAggregate> response
                ? response
                : new Reference<TAggregate>(reference.Id);
        }
    }
}