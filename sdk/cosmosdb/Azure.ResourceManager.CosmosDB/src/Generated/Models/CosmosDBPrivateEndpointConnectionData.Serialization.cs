// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB
{
    public partial class CosmosDBPrivateEndpointConnectionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateEndpoint))
            {
                writer.WritePropertyName("privateEndpoint");
                writer.WriteObjectValue(PrivateEndpoint);
            }
            if (Optional.IsDefined(PrivateLinkServiceConnectionState))
            {
                writer.WritePropertyName("privateLinkServiceConnectionState");
                writer.WriteObjectValue(PrivateLinkServiceConnectionState);
            }
            if (Optional.IsDefined(GroupId))
            {
                writer.WritePropertyName("groupId");
                writer.WriteStringValue(GroupId);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static CosmosDBPrivateEndpointConnectionData DeserializeCosmosDBPrivateEndpointConnectionData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<PrivateEndpointProperty> privateEndpoint = default;
            Optional<CosmosDBPrivateLinkServiceConnectionStateProperty> privateLinkServiceConnectionState = default;
            Optional<string> groupId = default;
            Optional<string> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("privateEndpoint"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            privateEndpoint = PrivateEndpointProperty.DeserializePrivateEndpointProperty(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("privateLinkServiceConnectionState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            privateLinkServiceConnectionState = CosmosDBPrivateLinkServiceConnectionStateProperty.DeserializeCosmosDBPrivateLinkServiceConnectionStateProperty(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("groupId"))
                        {
                            groupId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new CosmosDBPrivateEndpointConnectionData(id, name, type, systemData, privateEndpoint.Value, privateLinkServiceConnectionState.Value, groupId.Value, provisioningState.Value);
        }
    }
}
