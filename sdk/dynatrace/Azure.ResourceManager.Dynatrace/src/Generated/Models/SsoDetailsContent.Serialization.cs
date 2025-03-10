// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    public partial class SsoDetailsContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(UserPrincipal))
            {
                writer.WritePropertyName("userPrincipal");
                writer.WriteStringValue(UserPrincipal);
            }
            writer.WriteEndObject();
        }
    }
}
