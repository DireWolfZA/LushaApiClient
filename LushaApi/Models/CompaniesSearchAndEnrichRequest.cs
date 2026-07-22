using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompaniesSearchAndEnrichRequest")]
public class CompaniesSearchAndEnrichRequest {
    [JsonPropertyName("companies")]
    public required List<CompanySearchItem> Companies { get; set; }
    [JsonPropertyName("options")]
    public SearchOptions? Options { get; set; }
}
