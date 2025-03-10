// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageAccountCreateOrUpdateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sku");
            writer.WriteObjectValue(Sku);
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation");
                writer.WriteObjectValue(ExtendedLocation);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AllowedCopyScope))
            {
                writer.WritePropertyName("allowedCopyScope");
                writer.WriteStringValue(AllowedCopyScope.Value.ToString());
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess");
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(SasPolicy))
            {
                writer.WritePropertyName("sasPolicy");
                writer.WriteObjectValue(SasPolicy);
            }
            if (Optional.IsDefined(KeyPolicy))
            {
                writer.WritePropertyName("keyPolicy");
                writer.WriteObjectValue(KeyPolicy);
            }
            if (Optional.IsDefined(CustomDomain))
            {
                writer.WritePropertyName("customDomain");
                writer.WriteObjectValue(CustomDomain);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption");
                writer.WriteObjectValue(Encryption);
            }
            if (Optional.IsDefined(NetworkRuleSet))
            {
                writer.WritePropertyName("networkAcls");
                writer.WriteObjectValue(NetworkRuleSet);
            }
            if (Optional.IsDefined(AccessTier))
            {
                writer.WritePropertyName("accessTier");
                writer.WriteStringValue(AccessTier.Value.ToSerialString());
            }
            if (Optional.IsDefined(AzureFilesIdentityBasedAuthentication))
            {
                writer.WritePropertyName("azureFilesIdentityBasedAuthentication");
                writer.WriteObjectValue(AzureFilesIdentityBasedAuthentication);
            }
            if (Optional.IsDefined(EnableHttpsTrafficOnly))
            {
                writer.WritePropertyName("supportsHttpsTrafficOnly");
                writer.WriteBooleanValue(EnableHttpsTrafficOnly.Value);
            }
            if (Optional.IsDefined(IsSftpEnabled))
            {
                writer.WritePropertyName("isSftpEnabled");
                writer.WriteBooleanValue(IsSftpEnabled.Value);
            }
            if (Optional.IsDefined(IsLocalUserEnabled))
            {
                writer.WritePropertyName("isLocalUserEnabled");
                writer.WriteBooleanValue(IsLocalUserEnabled.Value);
            }
            if (Optional.IsDefined(IsHnsEnabled))
            {
                writer.WritePropertyName("isHnsEnabled");
                writer.WriteBooleanValue(IsHnsEnabled.Value);
            }
            if (Optional.IsDefined(LargeFileSharesState))
            {
                writer.WritePropertyName("largeFileSharesState");
                writer.WriteStringValue(LargeFileSharesState.Value.ToString());
            }
            if (Optional.IsDefined(RoutingPreference))
            {
                writer.WritePropertyName("routingPreference");
                writer.WriteObjectValue(RoutingPreference);
            }
            if (Optional.IsDefined(AllowBlobPublicAccess))
            {
                writer.WritePropertyName("allowBlobPublicAccess");
                writer.WriteBooleanValue(AllowBlobPublicAccess.Value);
            }
            if (Optional.IsDefined(MinimumTlsVersion))
            {
                writer.WritePropertyName("minimumTlsVersion");
                writer.WriteStringValue(MinimumTlsVersion.Value.ToString());
            }
            if (Optional.IsDefined(AllowSharedKeyAccess))
            {
                writer.WritePropertyName("allowSharedKeyAccess");
                writer.WriteBooleanValue(AllowSharedKeyAccess.Value);
            }
            if (Optional.IsDefined(EnableNfsV3))
            {
                writer.WritePropertyName("isNfsV3Enabled");
                writer.WriteBooleanValue(EnableNfsV3.Value);
            }
            if (Optional.IsDefined(AllowCrossTenantReplication))
            {
                writer.WritePropertyName("allowCrossTenantReplication");
                writer.WriteBooleanValue(AllowCrossTenantReplication.Value);
            }
            if (Optional.IsDefined(DefaultToOAuthAuthentication))
            {
                writer.WritePropertyName("defaultToOAuthAuthentication");
                writer.WriteBooleanValue(DefaultToOAuthAuthentication.Value);
            }
            if (Optional.IsDefined(ImmutableStorageWithVersioning))
            {
                writer.WritePropertyName("immutableStorageWithVersioning");
                writer.WriteObjectValue(ImmutableStorageWithVersioning);
            }
            if (Optional.IsDefined(DnsEndpointType))
            {
                writer.WritePropertyName("dnsEndpointType");
                writer.WriteStringValue(DnsEndpointType.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
