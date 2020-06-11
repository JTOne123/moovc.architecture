﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MooVC.Architecture {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MooVC.Architecture.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A reference to the aggregate from which conflicts were detected must be provided..
        /// </summary>
        internal static string AggregateConflictDetectedEventArgsAggregateRequired {
            get {
                return ResourceManager.GetString("AggregateConflictDetectedEventArgsAggregateRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The events within which conflicts were detected must be provided..
        /// </summary>
        internal static string AggregateConflictDetectedEventArgsEventsRequired {
            get {
                return ResourceManager.GetString("AggregateConflictDetectedEventArgsEventsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The version at which conflicts were detected must be provided..
        /// </summary>
        internal static string AggregateConflictDetectedEventArgsNextRequired {
            get {
                return ResourceManager.GetString("AggregateConflictDetectedEventArgsNextRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The version from which conflicts were detected must be provided..
        /// </summary>
        internal static string AggregateConflictDetectedEventArgsPreviousRequired {
            get {
                return ResourceManager.GetString("AggregateConflictDetectedEventArgsPreviousRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A conflict has been detected while attempting to commit changes to aggregate of type {1} with an ID of {0:p}.  Version {2} was received, but version {3} has been previously committed..
        /// </summary>
        internal static string AggregateConflictDetectedExceptionExistingEntryMessage {
            get {
                return ResourceManager.GetString("AggregateConflictDetectedExceptionExistingEntryMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A conflict has been detected while attempting to commit changes to aggregate of type {1} with an ID of {0:p}.  Version {2} was received, but the initial version was expected..
        /// </summary>
        internal static string AggregateConflictDetectedExceptionNoExistingEntryMessage {
            get {
                return ResourceManager.GetString("AggregateConflictDetectedExceptionNoExistingEntryMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An empty reference for aggregate type {0} cannot be retrieved..
        /// </summary>
        internal static string AggregateDoesNotExistExceptionMessage {
            get {
                return ResourceManager.GetString("AggregateDoesNotExistExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event {3:p}, version {5} of type {4} does not apply to aggregate {0:p}, version {2} of type {1}..
        /// </summary>
        internal static string AggregateEventMismatchExceptionMessage {
            get {
                return ResourceManager.GetString("AggregateEventMismatchExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Aggregate of type {2} with an ID of {0:p} and a version of {1} cannot accept the proposed state from history as the sequence is unordered..
        /// </summary>
        internal static string AggregateEventSequenceUnorderedExceptionMessage {
            get {
                return ResourceManager.GetString("AggregateEventSequenceUnorderedExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Aggregate of type {2} with an ID of {0:p} and a version of {1} cannot accept its state from history as it current possesses uncommitted changes..
        /// </summary>
        internal static string AggregateHasUncommittedChangesExceptionMessage {
            get {
                return ResourceManager.GetString("AggregateHasUncommittedChangesExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Aggregate of type {2} with an ID of {0:p} and a version of {1} cannot accept the proposed sequence as it starts from version {3}..
        /// </summary>
        internal static string AggregateHistoryInvalidForStateExceptionMessage {
            get {
                return ResourceManager.GetString("AggregateHistoryInvalidForStateExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request {0} could not be fulfilled due to a failure to satisfy the following invariants as defined by aggregate {1}:
        ///
        ///{2}.
        /// </summary>
        internal static string AggregateInvariantsNotSatisfiedDomainExceptionMessage {
            get {
                return ResourceManager.GetString("AggregateInvariantsNotSatisfiedDomainExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is currently no aggregate of type {1} with an ID of {0:p}..
        /// </summary>
        internal static string AggregateNotFoundExceptionMessage {
            get {
                return ResourceManager.GetString("AggregateNotFoundExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A reference to the aggregate that was successfull reconciled must be provided..
        /// </summary>
        internal static string AggregateReconciledEventArgsAggregateRequired {
            get {
                return ResourceManager.GetString("AggregateReconciledEventArgsAggregateRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The events that were successfully reconciled must be provided..
        /// </summary>
        internal static string AggregateReconciledEventArgsEventsRequired {
            get {
                return ResourceManager.GetString("AggregateReconciledEventArgsEventsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The factory from which aggregate type specific reconcilation proxies are produced must be provided..
        /// </summary>
        internal static string AggregateReconcilerFactoryRequired {
            get {
                return ResourceManager.GetString("AggregateReconcilerFactoryRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reference for aggregate {0:p} of type {1} cannot be converted type {2}..
        /// </summary>
        internal static string AggregateReferenceMismatchExceptionMessage {
            get {
                return ResourceManager.GetString("AggregateReferenceMismatchExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The aggregate that serves as the context for coordination must be provided..
        /// </summary>
        internal static string AggregateRootExtensionsCoordinateAggregateRequired {
            get {
                return ResourceManager.GetString("AggregateRootExtensionsCoordinateAggregateRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The destination must be provided..
        /// </summary>
        internal static string AggregateRootExtensionsDestinationRequired {
            get {
                return ResourceManager.GetString("AggregateRootExtensionsDestinationRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Version {2} of aggregate type {1} with an ID of {0:p} could not be found..
        /// </summary>
        internal static string AggregateVersionNotFoundExceptionMessage {
            get {
                return ResourceManager.GetString("AggregateVersionNotFoundExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The atomic unit must only contain changes relating to a single version increment of a single aggregate..
        /// </summary>
        internal static string AtomicUnitDistinctAggregateVersionRequired {
            get {
                return ResourceManager.GetString("AtomicUnitDistinctAggregateVersionRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The atomic unit must only contain changes triggered in the context of a single operation..
        /// </summary>
        internal static string AtomicUnitDistinctContextRequired {
            get {
                return ResourceManager.GetString("AtomicUnitDistinctContextRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The atomic unit must contain one or more domain events..
        /// </summary>
        internal static string AtomicUnitEventsRequired {
            get {
                return ResourceManager.GetString("AtomicUnitEventsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The message to be invoked must be provided..
        /// </summary>
        internal static string BusMessageRequired {
            get {
                return ResourceManager.GetString("BusMessageRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The repository must be provided..
        /// </summary>
        internal static string CoordinatedGenerateHandlerRepositoryRequired {
            get {
                return ResourceManager.GetString("CoordinatedGenerateHandlerRepositoryRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The repository must be provided..
        /// </summary>
        internal static string CoordinatedOperationHandlerRepositoryRequired {
            get {
                return ResourceManager.GetString("CoordinatedOperationHandlerRepositoryRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The store from which events are to be reconciled must be provided..
        /// </summary>
        internal static string DefaultEventReconcilerEventStoreRequired {
            get {
                return ResourceManager.GetString("DefaultEventReconcilerEventStoreRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The reconciler to be used to reconciled events must be provided..
        /// </summary>
        internal static string DefaultEventReconcilerReconcilerRequired {
            get {
                return ResourceManager.GetString("DefaultEventReconcilerReconcilerRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The aggregate reconciler must be provided..
        /// </summary>
        internal static string DefaultReconciliationOrchestratorAggregateReconcilerRequired {
            get {
                return ResourceManager.GetString("DefaultReconciliationOrchestratorAggregateReconcilerRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The source from which the aggregates are obtained must be provided..
        /// </summary>
        internal static string DefaultReconciliationOrchestratorAggregateSourceRequired {
            get {
                return ResourceManager.GetString("DefaultReconciliationOrchestratorAggregateSourceRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The event reconciler must be provided..
        /// </summary>
        internal static string DefaultReconciliationOrchestratorEventReconcilerRequired {
            get {
                return ResourceManager.GetString("DefaultReconciliationOrchestratorEventReconcilerRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The factory to be used to generate a new sequence must be provided..
        /// </summary>
        internal static string DefaultReconciliationOrchestratorSequenceFactoryRequired {
            get {
                return ResourceManager.GetString("DefaultReconciliationOrchestratorSequenceFactoryRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The store reponsible for tracking the event sequence must be provided..
        /// </summary>
        internal static string DefaultReconciliationOrchestratorSequenceStoreRequired {
            get {
                return ResourceManager.GetString("DefaultReconciliationOrchestratorSequenceStoreRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The source responsible for providing the snapshots must be provided..
        /// </summary>
        internal static string DefaultReconciliationOrchestratorSnapshotSourceRequired {
            get {
                return ResourceManager.GetString("DefaultReconciliationOrchestratorSnapshotSourceRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The store from which events are to be snapshot must be provided..
        /// </summary>
        internal static string DefaultSnapshotProviderEventStoreRequired {
            get {
                return ResourceManager.GetString("DefaultSnapshotProviderEventStoreRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The factory from which aggregate type specific reconcilation proxies are produced must be provided..
        /// </summary>
        internal static string DefaultSnapshotProviderFactoryRequired {
            get {
                return ResourceManager.GetString("DefaultSnapshotProviderFactoryRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A reference to the aggregate from which the domain event was raised must be provided..
        /// </summary>
        internal static string DomainEventAggregateReferenceRequired {
            get {
                return ResourceManager.GetString("DomainEventAggregateReferenceRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A versioned reference for the aggregate must be provided..
        /// </summary>
        internal static string DomainEventAggregateRequired {
            get {
                return ResourceManager.GetString("DomainEventAggregateRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The bus to which the events are to be propagated must be provided..
        /// </summary>
        internal static string DomainEventPropagatorBusRequired {
            get {
                return ResourceManager.GetString("DomainEventPropagatorBusRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The reconciler from which the events are to be propagated must be provided..
        /// </summary>
        internal static string DomainEventPropagatorReconcilerRequired {
            get {
                return ResourceManager.GetString("DomainEventPropagatorReconcilerRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The repository from which the events are to be propagated must be provided..
        /// </summary>
        internal static string DomainEventPropagatorRepositoryRequired {
            get {
                return ResourceManager.GetString("DomainEventPropagatorRepositoryRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The handler for the unhandled events must be provided..
        /// </summary>
        internal static string DomainEventsUnhandledEventArgsHandlerRequired {
            get {
                return ResourceManager.GetString("DomainEventsUnhandledEventArgsHandlerRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A non-empty reference of aggregate type {0} is required..
        /// </summary>
        internal static string EnsureReferenceIsNotEmptyMessage {
            get {
                return ResourceManager.GetString("EnsureReferenceIsNotEmptyMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The reference provided is for an aggregate of type {0}.  {1} is required..
        /// </summary>
        internal static string EnsureReferenceIsOfTypeMessage {
            get {
                return ResourceManager.GetString("EnsureReferenceIsOfTypeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The maximum supported ID of {0} for entity of type {1} has been exceeded..
        /// </summary>
        internal static string EntityMaximumIdValueExceededExceptionMessage {
            get {
                return ResourceManager.GetString("EntityMaximumIdValueExceededExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Changed to the state of an aggregate of type {0} must be made through ApplyChanges..
        /// </summary>
        internal static string EventCentricAggregateRootStateChangesDenied {
            get {
                return ResourceManager.GetString("EventCentricAggregateRootStateChangesDenied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The events must be provided..
        /// </summary>
        internal static string EventReconciliationEventArgsEventsRequired {
            get {
                return ResourceManager.GetString("EventReconciliationEventArgsEventsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The aggregate must be provided..
        /// </summary>
        internal static string GenericAggregateRequired {
            get {
                return ResourceManager.GetString("GenericAggregateRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The context for this request must be provided..
        /// </summary>
        internal static string GenericContextRequired {
            get {
                return ResourceManager.GetString("GenericContextRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A non-empty ID must be provided..
        /// </summary>
        internal static string GenericIdInvalid {
            get {
                return ResourceManager.GetString("GenericIdInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Handler for message of type {0} has failed to process message {1:p} for transaction {2:p}..
        /// </summary>
        internal static string HandlerFailureExceptionMessage {
            get {
                return ResourceManager.GetString("HandlerFailureExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The message that serves as the context for coordination must be provided..
        /// </summary>
        internal static string MessageExtensionsCoordinateMessageRequired {
            get {
                return ResourceManager.GetString("MessageExtensionsCoordinateMessageRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object that serves as the context for coordination must be provided..
        /// </summary>
        internal static string ObjectExtensionsCoordinateObjectRequired {
            get {
                return ResourceManager.GetString("ObjectExtensionsCoordinateObjectRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The paging instructions for this query must be provided..
        /// </summary>
        internal static string PaginatedQueryPagingRequired {
            get {
                return ResourceManager.GetString("PaginatedQueryPagingRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The paging instructions that generated the results must be provided..
        /// </summary>
        internal static string PaginatedResultPagingRequired {
            get {
                return ResourceManager.GetString("PaginatedResultPagingRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An attempt to publish atomic unit {0:p} has failed..
        /// </summary>
        internal static string PersistentBusPublishFailure {
            get {
                return ResourceManager.GetString("PersistentBusPublishFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The storage that support persistence of domain events published via the bus must be provided..
        /// </summary>
        internal static string PersistentBusStoreRequired {
            get {
                return ResourceManager.GetString("PersistentBusStoreRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The reference that serves as the context for coordination must be provided..
        /// </summary>
        internal static string ReferenceExtensionsCoordinateReferenceeRequired {
            get {
                return ResourceManager.GetString("ReferenceExtensionsCoordinateReferenceeRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An reference cannot be generated for abstract type {0} with an ID {1:p}..
        /// </summary>
        internal static string ReferenceTypeInvalid {
            get {
                return ResourceManager.GetString("ReferenceTypeInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The footer of previous version {0} is invalid..
        /// </summary>
        internal static string SignedVersionPreviousFooterInvalid {
            get {
                return ResourceManager.GetString("SignedVersionPreviousFooterInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The previous version must be provided..
        /// </summary>
        internal static string SignedVersionPreviousRequired {
            get {
                return ResourceManager.GetString("SignedVersionPreviousRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The sequence of the snapshot must be provided..
        /// </summary>
        internal static string SnapshotRestorationCompletedEventArgsSequenceRequired {
            get {
                return ResourceManager.GetString("SnapshotRestorationCompletedEventArgsSequenceRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The sequence for the snapshot must be provided..
        /// </summary>
        internal static string SnapshotSequenceRequired {
            get {
                return ResourceManager.GetString("SnapshotSequenceRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type that serves as the context for coordination must be provided..
        /// </summary>
        internal static string TypeExtensionsCoordinateTypeRequired {
            get {
                return ResourceManager.GetString("TypeExtensionsCoordinateTypeRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A type of the aggregate for which reconciliation is not supported must be provided..
        /// </summary>
        internal static string UnsupportedAggregateTypeDetectedEventArgsTypeRequired {
            get {
                return ResourceManager.GetString("UnsupportedAggregateTypeDetectedEventArgsTypeRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The version of the aggregate must be provided..
        /// </summary>
        internal static string VersionedReferenceVersionRequired {
            get {
                return ResourceManager.GetString("VersionedReferenceVersionRequired", resourceCulture);
            }
        }
    }
}
