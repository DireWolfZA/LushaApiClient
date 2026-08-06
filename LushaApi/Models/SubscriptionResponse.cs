using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "SubscriptionResponse")]
public class SubscriptionResponse {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EntityTypeEnum {
        [JsonStringEnumMemberName("contact")]
        Contact = 1,
        [JsonStringEnumMemberName("company")]
        Company = 2
    }

    [JsonPropertyName("id")]
    public string? ID { get; set; }
    [JsonPropertyName("entityType")]
    public EntityTypeEnum? EntityType { get; set; }
    [JsonPropertyName("entityId")]
    public string? EntityID { get; set; }
    [JsonPropertyName("signalTypes")]
    public List<string>? SignalTypes { get; set; }
    [JsonPropertyName("url")]
    public string? URL { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("isActive")]
    public bool? IsActive { get; set; }
    /// <summary>
    /// Webhook secret (only returned during creation or regeneration)
    /// </summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }
    [JsonPropertyName("updatedAt")]
    public DateTime? UpdatedAt { get; set; }
}
