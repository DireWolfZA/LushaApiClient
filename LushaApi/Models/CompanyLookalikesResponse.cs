using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "CompanyLookalikesResponse")]
public class CompanyLookalikesResponse {
    [JsonPropertyName("dedupeSessionId")]
    public required Guid DedupeSessionID { get; set; }
    [JsonPropertyName("results")]
    public required List<LookAlikeCompanyResult> Results { get; set; }
    [JsonPropertyName("meta")]
    public required CompanyLookalikesMeta Meta { get; set; }
    [JsonPropertyName("billing")]
    public Billing? Billing { get; set; }
}
