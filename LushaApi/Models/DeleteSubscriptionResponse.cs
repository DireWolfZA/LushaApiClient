using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "DeleteSubscriptionResponse")]
public class DeleteSubscriptionResponse {
    [JsonPropertyName("total")]
    public required int Total { get; set; }
    [JsonPropertyName("successful")]
    public required int Successful { get; set; }
    [JsonPropertyName("failed")]
    public required int Failed { get; set; }
    /// <summary>Array of <see cref="DeleteSubscriptionSuccessResult"/> or <see cref="DeleteSubscriptionErrorResult"/></summary>
    [JsonPropertyName("results")]
    public required List<DeleteSubscriptionResponseResult> Results { get; set; }
}
