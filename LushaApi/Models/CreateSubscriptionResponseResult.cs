using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "CreateSubscriptionResponse_results_inner")]
public class CreateSubscriptionResponseResult {
    [JsonPropertyName("index")]
    public virtual required int Index { get; set; }
    [JsonPropertyName("success")]
    public virtual required bool Success { get; set; }
    [JsonPropertyName("subscription")]
    public virtual SubscriptionWithoutSecret? Subscription { get; set; }
    [JsonPropertyName("error")]
    public virtual CreateSubscriptionErrorResultError? Error { get; set; }
}
