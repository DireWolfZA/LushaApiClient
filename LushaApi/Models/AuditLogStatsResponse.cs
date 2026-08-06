using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "AuditLogStatsResponse")]
public class AuditLogStatsResponse {
    [JsonPropertyName("total")]
    public required int Total { get; set; }
    [JsonPropertyName("success")]
    public required int Success { get; set; }
    [JsonPropertyName("failed")]
    public required int Failed { get; set; }
    [JsonPropertyName("successRate")]
    public required string SuccessRate { get; set; }

    // not in OpenAPI schema, but found in response
    [JsonPropertyName("permanentFailure")]
    public int? PermanentFailure { get; set; }
    [JsonPropertyName("dlq")]
    public int? DLQ { get; set; }
    [JsonPropertyName("totalCreditsConsumed")]
    public int? TotalCreditsConsumed { get; set; }
}
