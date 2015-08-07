// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Application logs configuration
    /// </summary>
    public partial class ApplicationLogsConfig
    {
        /// <summary>
        /// Application logs to file system configuration
        /// </summary>
        [JsonProperty(PropertyName = "fileSystem")]
        public FileSystemApplicationLogsConfig FileSystem { get; set; }

        /// <summary>
        /// Application logs to azure table storage configuration
        /// </summary>
        [JsonProperty(PropertyName = "azureTableStorage")]
        public AzureTableStorageApplicationLogsConfig AzureTableStorage { get; set; }

        /// <summary>
        /// Application logs to blob storage configuration
        /// </summary>
        [JsonProperty(PropertyName = "azureBlobStorage")]
        public AzureBlobStorageApplicationLogsConfig AzureBlobStorage { get; set; }

    }
}
