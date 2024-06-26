// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.OracleDatabase.Models;

namespace Azure.ResourceManager.OracleDatabase
{
    /// <summary>
    /// A Class representing a DbNode along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="DbNodeResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetDbNodeResource method.
    /// Otherwise you can get one from its parent resource <see cref="CloudVmClusterResource"/> using the GetDbNode method.
    /// </summary>
    public partial class DbNodeResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DbNodeResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="cloudvmclustername"> The cloudvmclustername. </param>
        /// <param name="dbnodeocid"> The dbnodeocid. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string cloudvmclustername, string dbnodeocid)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}/dbNodes/{dbnodeocid}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dbNodeClientDiagnostics;
        private readonly DbNodesRestOperations _dbNodeRestClient;
        private readonly DbNodeData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Oracle.Database/cloudVmClusters/dbNodes";

        /// <summary> Initializes a new instance of the <see cref="DbNodeResource"/> class for mocking. </summary>
        protected DbNodeResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DbNodeResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DbNodeResource(ArmClient client, DbNodeData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DbNodeResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DbNodeResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dbNodeClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.OracleDatabase", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string dbNodeApiVersion);
            _dbNodeRestClient = new DbNodesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dbNodeApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DbNodeData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a DbNode
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}/dbNodes/{dbnodeocid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DbNodes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DbNodeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DbNodeResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dbNodeClientDiagnostics.CreateScope("DbNodeResource.Get");
            scope.Start();
            try
            {
                var response = await _dbNodeRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DbNodeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a DbNode
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}/dbNodes/{dbnodeocid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DbNodes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DbNodeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DbNodeResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _dbNodeClientDiagnostics.CreateScope("DbNodeResource.Get");
            scope.Start();
            try
            {
                var response = _dbNodeRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DbNodeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// VM actions on DbNode of VM Cluster by the provided filter
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}/dbNodes/{dbnodeocid}/action</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DbNodes_Action</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DbNodeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="body"> The content of the action request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public virtual async Task<ArmOperation<DbNodeResource>> ActionAsync(WaitUntil waitUntil, DbNodeAction body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(body, nameof(body));

            using var scope = _dbNodeClientDiagnostics.CreateScope("DbNodeResource.Action");
            scope.Start();
            try
            {
                var response = await _dbNodeRestClient.ActionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, body, cancellationToken).ConfigureAwait(false);
                var operation = new OracleDatabaseArmOperation<DbNodeResource>(new DbNodeOperationSource(Client), _dbNodeClientDiagnostics, Pipeline, _dbNodeRestClient.CreateActionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, body).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// VM actions on DbNode of VM Cluster by the provided filter
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}/dbNodes/{dbnodeocid}/action</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DbNodes_Action</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DbNodeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="body"> The content of the action request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public virtual ArmOperation<DbNodeResource> Action(WaitUntil waitUntil, DbNodeAction body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(body, nameof(body));

            using var scope = _dbNodeClientDiagnostics.CreateScope("DbNodeResource.Action");
            scope.Start();
            try
            {
                var response = _dbNodeRestClient.Action(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, body, cancellationToken);
                var operation = new OracleDatabaseArmOperation<DbNodeResource>(new DbNodeOperationSource(Client), _dbNodeClientDiagnostics, Pipeline, _dbNodeRestClient.CreateActionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, body).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
