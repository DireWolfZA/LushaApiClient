using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "CreateSubscriptionRequest_subscriptions_inner")]
public class CreateSubscriptionRequestSubscriptionsInner {
    /// <summary>
    /// Overrides default entityType
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EntityTypeEnum {
        [JsonStringEnumMemberName("contact")]
        Contact = 1,
        [JsonStringEnumMemberName("company")]
        Company = 2
    }

    /// <summary>
    /// Entity ID (always required per item)
    /// </summary>
    [JsonPropertyName("entityId")]
    public required string EntityID { get; set; }
    /// <summary>
    /// Overrides default entityType
    /// </summary>
    [JsonPropertyName("entityType")]
    public EntityTypeEnum? EntityType { get; set; }
    /// <summary>
    /// Overrides default signalTypes
    /// </summary>
    [JsonPropertyName("signalTypes")]
    public List<string>? SignalTypes { get; set; }
    /// <summary>
    /// Overrides default name
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
