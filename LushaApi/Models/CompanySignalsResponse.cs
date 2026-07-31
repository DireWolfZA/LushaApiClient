using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompanySignalsResponse")]
public class CompanySignalsResponse {
    [JsonPropertyName("results")]
    public List<CompanySignalsResponseResultsInner>? Results { get; set; }
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }
    [JsonPropertyName("billing")]
    public Billing? Billing { get; set; }
}
