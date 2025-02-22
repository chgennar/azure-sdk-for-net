// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.WebPubSub.Models;

namespace Azure.ResourceManager.WebPubSub
{
    public partial class WebPubSubData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Tls))
            {
                writer.WritePropertyName("tls");
                writer.WriteObjectValue(Tls);
            }
            if (Optional.IsDefined(LiveTraceConfiguration))
            {
                writer.WritePropertyName("liveTraceConfiguration");
                writer.WriteObjectValue(LiveTraceConfiguration);
            }
            if (Optional.IsDefined(ResourceLogConfiguration))
            {
                writer.WritePropertyName("resourceLogConfiguration");
                writer.WriteObjectValue(ResourceLogConfiguration);
            }
            if (Optional.IsDefined(NetworkAcls))
            {
                writer.WritePropertyName("networkACLs");
                writer.WriteObjectValue(NetworkAcls);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess");
                writer.WriteStringValue(PublicNetworkAccess);
            }
            if (Optional.IsDefined(DisableLocalAuth))
            {
                writer.WritePropertyName("disableLocalAuth");
                writer.WriteBooleanValue(DisableLocalAuth.Value);
            }
            if (Optional.IsDefined(DisableAadAuth))
            {
                writer.WritePropertyName("disableAadAuth");
                writer.WriteBooleanValue(DisableAadAuth.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static WebPubSubData DeserializeWebPubSubData(JsonElement element)
        {
            Optional<WebPubSubSku> sku = default;
            Optional<ManagedIdentity> identity = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> externalIP = default;
            Optional<string> hostName = default;
            Optional<int> publicPort = default;
            Optional<int> serverPort = default;
            Optional<string> version = default;
            Optional<IReadOnlyList<WebPubSubPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<IReadOnlyList<SharedPrivateLinkData>> sharedPrivateLinkResources = default;
            Optional<WebPubSubTlsSettings> tls = default;
            Optional<string> hostNamePrefix = default;
            Optional<LiveTraceConfiguration> liveTraceConfiguration = default;
            Optional<ResourceLogConfiguration> resourceLogConfiguration = default;
            Optional<WebPubSubNetworkAcls> networkACLs = default;
            Optional<string> publicNetworkAccess = default;
            Optional<bool> disableLocalAuth = default;
            Optional<bool> disableAadAuth = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = WebPubSubSku.DeserializeWebPubSubSku(property.Value);
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = ManagedIdentity.DeserializeManagedIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
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
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("externalIP"))
                        {
                            externalIP = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostName"))
                        {
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publicPort"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            publicPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("serverPort"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            serverPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("version"))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<WebPubSubPrivateEndpointConnectionData> array = new List<WebPubSubPrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(WebPubSubPrivateEndpointConnectionData.DeserializeWebPubSubPrivateEndpointConnectionData(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("sharedPrivateLinkResources"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SharedPrivateLinkData> array = new List<SharedPrivateLinkData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SharedPrivateLinkData.DeserializeSharedPrivateLinkData(item));
                            }
                            sharedPrivateLinkResources = array;
                            continue;
                        }
                        if (property0.NameEquals("tls"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            tls = WebPubSubTlsSettings.DeserializeWebPubSubTlsSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hostNamePrefix"))
                        {
                            hostNamePrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("liveTraceConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            liveTraceConfiguration = LiveTraceConfiguration.DeserializeLiveTraceConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("resourceLogConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            resourceLogConfiguration = ResourceLogConfiguration.DeserializeResourceLogConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("networkACLs"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            networkACLs = WebPubSubNetworkAcls.DeserializeWebPubSubNetworkAcls(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"))
                        {
                            publicNetworkAccess = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("disableLocalAuth"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            disableLocalAuth = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("disableAadAuth"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            disableAadAuth = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new WebPubSubData(id, name, type, systemData, tags, location, sku.Value, identity.Value, Optional.ToNullable(provisioningState), externalIP.Value, hostName.Value, Optional.ToNullable(publicPort), Optional.ToNullable(serverPort), version.Value, Optional.ToList(privateEndpointConnections), Optional.ToList(sharedPrivateLinkResources), tls.Value, hostNamePrefix.Value, liveTraceConfiguration.Value, resourceLogConfiguration.Value, networkACLs.Value, publicNetworkAccess.Value, Optional.ToNullable(disableLocalAuth), Optional.ToNullable(disableAadAuth));
        }
    }
}
