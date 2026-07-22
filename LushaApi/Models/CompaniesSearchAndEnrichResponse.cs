using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompaniesSearchAndEnrichResponse")]
public class CompaniesSearchAndEnrichResponse {
    public CompaniesSearchAndEnrichResponse(Guid? requestID = null, List<SearchAndEnrichCompanyResult>? results = null, Billing? billing = null) {
        this.RequestID = requestID;
        this.Results = results;
        this.Billing = billing;
    }

    [JsonPropertyName("requestId")]
    public Guid? RequestID { get; set; }
    [JsonPropertyName("results")]
    public List<SearchAndEnrichCompanyResult>? Results { get; set; }
    [JsonPropertyName("billing")]
    public Billing? Billing { get; set; }
}
