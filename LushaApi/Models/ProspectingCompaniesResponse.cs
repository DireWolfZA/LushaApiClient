using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ProspectingCompaniesResponse")]
public class ProspectingCompaniesResponse {
    [JsonPropertyName("requestId")]
    public Guid? RequestID { get; set; }
    [JsonPropertyName("results")]
    public List<CompanyPreview>? Results { get; set; }
    [JsonPropertyName("pagination")]
    public PaginationResponse? Pagination { get; set; }
    [JsonPropertyName("billing")]
    public Billing? Billing { get; set; }
}
