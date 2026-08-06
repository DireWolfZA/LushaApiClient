using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "TestSubscriptionResponse_flowCheck")]
public class TestSubscriptionResponseFlowCheck {
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
    [JsonPropertyName("statusCode")]
    public int? StatusCode { get; set; }
    [JsonPropertyName("durationMs")]
    public int? DurationMS { get; set; }
}
