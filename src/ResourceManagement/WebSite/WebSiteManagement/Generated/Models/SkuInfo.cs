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
    /// Sku discovery information
    /// </summary>
    public partial class SkuInfo
    {
        /// <summary>
        /// Name and tier of the sku
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public SkuDescription Sku { get; set; }

        /// <summary>
        /// Min, max, and default scale values of the sku
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public SkuCapacity Capacity { get; set; }

    }
}
