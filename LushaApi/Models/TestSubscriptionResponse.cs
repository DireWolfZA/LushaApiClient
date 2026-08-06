using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "TestSubscriptionResponse")]
public class TestSubscriptionResponse {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ModeEnum {
        [JsonStringEnumMemberName("direct")]
        Direct = 1,
        [JsonStringEnumMemberName("kafka")]
        Kafka = 2,
        [JsonStringEnumMemberName("full")]
        Full = 3
    }

    [JsonPropertyName("subscriptionId")]
    public required string SubscriptionID { get; set; }
    [JsonPropertyName("subscriptionName")]
    public string? SubscriptionName { get; set; }
    [JsonPropertyName("url")]
    public required string URL { get; set; }
    [JsonPropertyName("mode")]
    public required ModeEnum Mode { get; set; }
    [JsonPropertyName("flowCheck")]
    public TestSubscriptionResponseFlowCheck? FlowCheck { get; set; }
    [JsonPropertyName("testPayload")]
    public TestSubscriptionResponseTestPayload? TestPayload { get; set; }
    [JsonPropertyName("isSuccess")]
    public required bool IsSuccess { get; set; }
    [JsonPropertyName("timestamp")]
    public required DateTime Timestamp { get; set; }
}
