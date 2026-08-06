using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "CreateSubscriptionRequest")]
public class CreateSubscriptionRequest {
    [JsonPropertyName("defaults")]
    public required CreateSubscriptionRequestDefaults Defaults { get; set; }
    /// <summary>
    /// Default subscription name prefix
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// Array of subscriptions to create (max 25)
    /// </summary>
    [JsonPropertyName("subscriptions")]
    public required List<CreateSubscriptionRequestSubscriptionsInner> Subscriptions { get; set; }
}
