// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class VirtualMachineScaleSetHardwareProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(VmSizeProperties))
            {
                writer.WritePropertyName("vmSizeProperties");
                writer.WriteObjectValue(VmSizeProperties);
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineScaleSetHardwareProfile DeserializeVirtualMachineScaleSetHardwareProfile(JsonElement element)
        {
            Optional<VmSizeProperties> vmSizeProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmSizeProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    vmSizeProperties = VmSizeProperties.DeserializeVmSizeProperties(property.Value);
                    continue;
                }
            }
            return new VirtualMachineScaleSetHardwareProfile(vmSizeProperties.Value);
        }
    }
}
