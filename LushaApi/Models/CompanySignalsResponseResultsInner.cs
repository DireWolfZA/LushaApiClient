using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompanySignalsResponse_results_inner")]
public class CompanySignalsResponseResultsInner {
    [JsonPropertyName("id")]
    public string? ID { get; set; }
    [JsonPropertyName("companyName")]
    public string? CompanyName { get; set; }
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }
    [JsonExtensionData]
    public IDictionary<string, object>? AdditionalProperties { get; set; }
}
