using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "SubscriptionWithoutSecret")]
public class SubscriptionWithoutSecret {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EntityTypeEnum {
        [JsonStringEnumMemberName("contact")]
        Contact = 1,
        [JsonStringEnumMemberName("company")]
        Company = 2
    }

    [JsonPropertyName("id")]
    public required string ID { get; set; }
    [JsonPropertyName("entityType")]
    public required EntityTypeEnum EntityType { get; set; }
    [JsonPropertyName("entityId")]
    public required string EntityID { get; set; }
    [JsonPropertyName("signalTypes")]
    public required List<string> SignalTypes { get; set; }
    [JsonPropertyName("url")]
    public required string URL { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("isActive")]
    public required bool IsActive { get; set; }
    /// <summary>
    /// Reason subscription was disabled (null if active)
    /// </summary>
    [JsonPropertyName("blockReason")]
    public string? BlockReason { get; set; }
    /// <summary>
    /// When subscription was disabled (null if active)
    /// </summary>
    [JsonPropertyName("blockedAt")]
    public DateTime? BlockedAt { get; set; }
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }
}
