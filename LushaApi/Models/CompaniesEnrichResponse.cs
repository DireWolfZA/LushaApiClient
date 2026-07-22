using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompaniesEnrichResponse")]
public class CompaniesEnrichResponse {
    public CompaniesEnrichResponse(Guid? requestID = null, List<EnrichedCompany>? results = null, Billing? billing = null) {
        this.RequestID = requestID;
        this.Results = results;
        this.Billing = billing;
    }

    [JsonPropertyName("requestId")]
    public Guid? RequestID { get; set; }
    [JsonPropertyName("results")]
    public List<EnrichedCompany>? Results { get; set; }
    [JsonPropertyName("billing")]
    public Billing? Billing { get; set; }
}
