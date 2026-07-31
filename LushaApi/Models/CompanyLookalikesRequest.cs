using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "CompanyLookalikesRequest")]
public class CompanyLookalikesRequest {
    [JsonPropertyName("dedupeSessionId")]
    public Guid? DedupeSessionID { get; set; }
    [JsonPropertyName("seeds")]
    public required CompanyIdentifiersBatch Seeds { get; set; }
    [JsonPropertyName("exclude")]
    public CompanyIdentifiersBatch? Exclude { get; set; }
    /// <summary>Default: 25</summary>
    [JsonPropertyName("limit")]
    public int? Limit { get; set; }
}
