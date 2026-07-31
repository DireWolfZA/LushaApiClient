using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ContactSignalsResponse")]
public class ContactSignalsResponse {
    [JsonPropertyName("results")]
    public List<ContactSignalsResponseResultsInner>? Results { get; set; }
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }
    [JsonPropertyName("billing")]
    public Billing? Billing { get; set; }
}
