﻿namespace MooVC.Architecture.Ddd.Services
{
    public interface IEventReconciler
    {
        public event EventsReconciledEventHandler EventsReconciled;

        public event EventsReconcilingEventHandler EventsReconciling;

        public event EventSequenceAdvancedEventHandler EventSequenceAdvanced;

        ulong Reconcile();
    }
}