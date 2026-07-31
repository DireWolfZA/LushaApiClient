using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ContactSignalsResponse_results_inner")]
public class ContactSignalsResponseResultsInner {
    [JsonPropertyName("id")]
    public string? ID { get; set; }
    [JsonPropertyName("companyChange")]
    public List<object>? CompanyChange { get; set; }
    [JsonPropertyName("promotion")]
    public List<object>? Promotion { get; set; }
}
