using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "TestSubscriptionResponse_testPayload")]
public class TestSubscriptionResponseTestPayload {
    [JsonPropertyName("entityType")]
    public string? EntityType { get; set; }
    [JsonPropertyName("signalType")]
    public string? SignalType { get; set; }
    [JsonPropertyName("data")]
    public object? Data { get; set; }
}
