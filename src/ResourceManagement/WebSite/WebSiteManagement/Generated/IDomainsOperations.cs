// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using System.Linq;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// DomainsOperations operations.
    /// </summary>
    public partial interface IDomainsOperations
    {
        /// <summary>
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<DomainCollection>> GetDomainsWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='domainName'>
        /// Name of the domain
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Domain>> GetDomainWithHttpMessagesAsync(string resourceGroupName, string domainName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// </summary>
        /// <param name='resourceGroupName'>
        /// &amp;gt;Name of the resource group
        /// </param>
        /// <param name='domainName'>
        /// Name of the domain
        /// </param>
        /// <param name='domain'>
        /// Domain registration information
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Domain>> CreateOrUpdateDomainWithHttpMessagesAsync(string resourceGroupName, string domainName, Domain domain, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='domainName'>
        /// Name of the domain
        /// </param>
        /// <param name='forceHardDeleteDomain'>
        /// If true then the domain will be deleted immediately instead of
        /// after 24 hours
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<object>> DeleteDomainWithHttpMessagesAsync(string resourceGroupName, string domainName, bool? forceHardDeleteDomain = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// </summary>
        /// <param name='resourceGroupName'>
        /// &amp;gt;Name of the resource group
        /// </param>
        /// <param name='domainName'>
        /// Name of the domain
        /// </param>
        /// <param name='domain'>
        /// Domain registration information
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Domain>> UpdateDomainWithHttpMessagesAsync(string resourceGroupName, string domainName, Domain domain, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='domainName'>
        /// Name of the domain
        /// </param>
        /// <param name='operationId'>
        /// Domain purchase operation Id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Domain>> GetDomainOperationWithHttpMessagesAsync(string resourceGroupName, string domainName, string operationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
