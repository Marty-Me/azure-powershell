// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// ProtectionContainerRefreshOperationResultsOperations operations.
    /// </summary>
    public partial interface IProtectionContainerRefreshOperationResultsOperations
    {
        /// <summary>
        /// Provides the result of the refresh operation triggered by the BeginRefresh operation.
        /// </summary>
        /// <remarks>
        /// Provides the result of the refresh operation triggered by the BeginRefresh operation.
        /// </remarks>
        /// <param name='vaultName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is present.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name associated with the container.
        /// </param>
        /// <param name='operationId'>
        /// Operation ID associated with the operation whose result needs to be fetched.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> GetWithHttpMessagesAsync(string vaultName, string resourceGroupName, string fabricName, string operationId, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}