// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text;
using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Search.Models
{
    internal partial class DataPlaneAadOrApiKeyAuthOption : IModelJsonSerializable<DataPlaneAadOrApiKeyAuthOption>
    {
        void IModelJsonSerializable<DataPlaneAadOrApiKeyAuthOption>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options) => ((IUtf8JsonSerializable)this).Write(writer);

        DataPlaneAadOrApiKeyAuthOption IModelJsonSerializable<DataPlaneAadOrApiKeyAuthOption>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            using var document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataPlaneAadOrApiKeyAuthOption(document.RootElement);
        }

        BinaryData IModelSerializable<DataPlaneAadOrApiKeyAuthOption>.Serialize(ModelSerializerOptions options) => (options.Format.ToString()) switch
        {
            "J" or "W" => ModelSerializer.SerializeCore(this, options),
            "bicep" => SerializeBicep(options),
            _ => throw new FormatException($"Unsupported format {options.Format}")
        };

        DataPlaneAadOrApiKeyAuthOption IModelSerializable<DataPlaneAadOrApiKeyAuthOption>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            using var document = JsonDocument.Parse(data);
            return DeserializeDataPlaneAadOrApiKeyAuthOption(document.RootElement);
        }

        private BinaryData SerializeBicep(ModelSerializerOptions options)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"  aadAuthFailureMode: '{AadAuthFailureMode.Value.ToSerialString()}'");
            return new BinaryData(sb.ToString());
        }
    }
}
