using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "DeleteSubscriptionSuccessResult")]
public class DeleteSubscriptionSuccessResult : DeleteSubscriptionResponseResult {
    //[JsonPropertyName("index")]
    //public override required int Index { get; set; }
    //[JsonPropertyName("success")]
    //public override required bool Success { get; set; }
    [JsonPropertyName("subscription"), AllowNull]
    public override required DeleteSubscriptionSuccessResultSubscription Subscription { get; set; }
}
