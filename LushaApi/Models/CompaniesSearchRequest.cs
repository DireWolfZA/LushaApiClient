using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompaniesSearchRequest")]
public class CompaniesSearchRequest {
    [JsonPropertyName("companies")]
    public required List<CompanySearchItem> Companies { get; set; }
    [JsonPropertyName("options")]
    public SearchOptions? Options { get; set; }
    [JsonPropertyName("signals")]
    public CompanySignals? Signals { get; set; }
}
