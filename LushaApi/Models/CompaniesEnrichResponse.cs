using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompaniesEnrichResponse")]
public class CompaniesEnrichResponse {
    [JsonPropertyName("requestId")]
    public Guid? RequestID { get; set; }
    [JsonPropertyName("results")]
    public List<EnrichedCompany>? Results { get; set; }
    [JsonPropertyName("billing")]
    public Billing? Billing { get; set; }
}
