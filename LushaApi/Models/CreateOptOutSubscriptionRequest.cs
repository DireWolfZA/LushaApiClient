using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

/// <summary>
/// Request body for creating an opt-out webhook subscription
/// </summary>
[DataContract(Name = "CreateOptOutSubscriptionRequest")]
public class CreateOptOutSubscriptionRequest {
    /// <summary>
    /// Entity type for opt-out subscriptions. Currently only `contact` is supported.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EntityTypeEnum {
        [JsonStringEnumMemberName("contact")]
        Contact = 1
    }

    /// <summary>
    /// Entity type for opt-out subscriptions. Currently only `contact` is supported.
    /// </summary>
    [JsonPropertyName("entityType")]
    public required EntityTypeEnum EntityType { get; set; }
    /// <summary>
    /// Your webhook endpoint URL (HTTPS required in production)
    /// </summary>
    [JsonPropertyName("url")]
    public required string URL { get; set; }
    /// <summary>
    /// Descriptive name for this subscription
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
