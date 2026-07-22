using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

/// <summary>
/// Per-item error in a batch response
/// </summary>
[DataContract(Name = "V3ItemError")]
public class ItemError {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CodeEnum {
        [EnumMember(Value = "NOT_FOUND")]
        NotFound = 1,
        [EnumMember(Value = "COMPLIANCE_RESTRICTED")]
        ComplianceRestricted = 2,
        [EnumMember(Value = "ENRICH_FAILED")]
        EnrichFailed = 3
    }

    [JsonPropertyName("code")]
    public CodeEnum? Code { get; set; }
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}
