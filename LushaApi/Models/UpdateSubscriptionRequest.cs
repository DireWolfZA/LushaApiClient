using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "UpdateSubscriptionRequest")]
public class UpdateSubscriptionRequest {
    /// <summary>
    /// New signal types to subscribe to
    /// </summary>
    [JsonPropertyName("signalTypes")]
    public List<string>? SignalTypes { get; set; }
    /// <summary>
    /// New webhook URL
    /// </summary>
    [JsonPropertyName("url")]
    public string? URL { get; set; }
    /// <summary>
    /// New subscription name
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// Enable or disable subscription
    /// </summary>
    [JsonPropertyName("isActive")]
    public bool? IsActive { get; set; }
    /// <summary>
    /// Generate new webhook secret (secret will be returned in response)
    /// </summary>
    [JsonPropertyName("regenerateSecret")]
    public bool? RegenerateSecret { get; set; }
}
