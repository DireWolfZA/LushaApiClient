using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "DeleteSubscriptionSuccessResult_subscription")]
public class DeleteSubscriptionSuccessResultSubscription {
    [JsonPropertyName("id")]
    public string? ID { get; set; }
    [JsonPropertyName("entityType")]
    public string? EntityType { get; set; }
    [JsonPropertyName("entityId")]
    public string? EntityID { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
