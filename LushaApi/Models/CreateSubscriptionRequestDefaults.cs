using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "CreateSubscriptionRequest_defaults")]
public class CreateSubscriptionRequestDefaults {
    /// <summary>
    /// Default entity type for all subscriptions
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EntityTypeEnum {
        [JsonStringEnumMemberName("contact")]
        Contact = 1,
        [JsonStringEnumMemberName("company")]
        Company = 2
    }

    /// <summary>
    /// Webhook URL (HTTPS required in production)
    /// </summary>
    [JsonPropertyName("url")]
    public required string URL { get; set; }
    /// <summary>
    /// Default entity type for all subscriptions
    /// </summary>
    [JsonPropertyName("entityType")]
    public EntityTypeEnum? EntityType { get; set; }
    /// <summary>
    /// Default signal types for all subscriptions
    /// </summary>
    [JsonPropertyName("signalTypes")]
    public List<string>? SignalTypes { get; set; }
}
