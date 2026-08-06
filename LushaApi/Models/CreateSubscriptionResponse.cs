using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "CreateSubscriptionResponse")]
public class CreateSubscriptionResponse {
    [JsonPropertyName("total")]
    public required int Total { get; set; }
    [JsonPropertyName("successful")]
    public required int Successful { get; set; }
    [JsonPropertyName("failed")]
    public required int Failed { get; set; }
    /// <summary>Array of <see cref="CreateSubscriptionSuccessResult"/> or <see cref="CreateSubscriptionErrorResult"/></summary>
    [JsonPropertyName("results")]
    public required List<CreateSubscriptionResponseResult> Results { get; set; }
}
