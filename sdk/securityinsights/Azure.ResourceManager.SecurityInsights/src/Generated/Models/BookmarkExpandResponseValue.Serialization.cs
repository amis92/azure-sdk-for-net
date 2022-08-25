// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class BookmarkExpandResponseValue
    {
        internal static BookmarkExpandResponseValue DeserializeBookmarkExpandResponseValue(JsonElement element)
        {
            Optional<IReadOnlyList<EntityData>> entities = default;
            Optional<IReadOnlyList<ConnectedEntity>> edges = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("entities"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<EntityData> array = new List<EntityData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EntityData.DeserializeEntityData(item));
                    }
                    entities = array;
                    continue;
                }
                if (property.NameEquals("edges"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ConnectedEntity> array = new List<ConnectedEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectedEntity.DeserializeConnectedEntity(item));
                    }
                    edges = array;
                    continue;
                }
            }
            return new BookmarkExpandResponseValue(Optional.ToList(entities), Optional.ToList(edges));
        }
    }
}
