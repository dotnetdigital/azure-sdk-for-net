// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    public partial class RoleAssignmentScheduleInfoExpiration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RoleAssignmentExpirationType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(RoleAssignmentExpirationType.Value.ToString());
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endDateTime");
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration");
                writer.WriteStringValue(Duration.Value, "c");
            }
            writer.WriteEndObject();
        }

        internal static RoleAssignmentScheduleInfoExpiration DeserializeRoleAssignmentScheduleInfoExpiration(JsonElement element)
        {
            Optional<RoleAssignmentScheduleType> type = default;
            Optional<DateTimeOffset> endDateTime = default;
            Optional<TimeSpan> duration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new RoleAssignmentScheduleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("endDateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("duration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    duration = property.Value.GetTimeSpan("c");
                    continue;
                }
            }
            return new RoleAssignmentScheduleInfoExpiration(Optional.ToNullable(type), Optional.ToNullable(endDateTime), Optional.ToNullable(duration));
        }
    }
}
