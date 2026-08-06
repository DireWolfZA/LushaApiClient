using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

/// <summary>
/// Response body returned when an opt-out subscription is created successfully
/// </summary>
[DataContract(Name = "OptOutSubscriptionResponse")]
public class OptOutSubscriptionResponse {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EntityTypeEnum {
        [JsonStringEnumMemberName("contact")]
        Contact = 1
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
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }
}
