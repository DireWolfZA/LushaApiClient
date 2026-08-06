using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "AuditLogEntry")]
public class AuditLogEntry {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StatusEnum {
        [JsonStringEnumMemberName("success")]
        Success = 1,
        [JsonStringEnumMemberName("failed")]
        Failed = 2,
        [JsonStringEnumMemberName("permanent_failure")]
        PermanentFailure = 3
    }

    [JsonPropertyName("id")]
    public required string ID { get; set; }
    [JsonPropertyName("subscriptionId")]
    public required string SubscriptionID { get; set; }
    [JsonPropertyName("payloadId")]
    public required string PayloadID { get; set; }
    [JsonPropertyName("status")]
    public required StatusEnum Status { get; set; }
    [JsonPropertyName("statusCode")]
    public int? StatusCode { get; set; }
    [JsonPropertyName("url")]
    public required string URL { get; set; }
    [JsonPropertyName("deliveredAt")]
    public required DateTime DeliveredAt { get; set; }
    [JsonPropertyName("durationMs")]
    public int? DurationMS { get; set; }
    [JsonPropertyName("error")]
    public string? Error { get; set; }
}
