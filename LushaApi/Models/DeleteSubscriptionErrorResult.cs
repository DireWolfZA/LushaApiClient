using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "DeleteSubscriptionErrorResult")]
public class DeleteSubscriptionErrorResult : DeleteSubscriptionResponseResult {
    //[JsonPropertyName("index")]
    //public override required int Index { get; set; }
    //[JsonPropertyName("success")]
    //public override required bool Success { get; set; }
    [JsonPropertyName("error"), AllowNull]
    public override required DeleteSubscriptionErrorResultError Error { get; set; }
}
