using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "DeleteSubscriptionResponse_results_inner")]
public class DeleteSubscriptionResponseResult {
    [JsonPropertyName("index")]
    public virtual required int Index { get; set; }
    [JsonPropertyName("success")]
    public virtual required bool Success { get; set; }
    [JsonPropertyName("subscription")]
    public virtual DeleteSubscriptionSuccessResultSubscription? Subscription { get; set; }
    [JsonPropertyName("error")]
    public virtual DeleteSubscriptionErrorResultError? Error { get; set; }
}
