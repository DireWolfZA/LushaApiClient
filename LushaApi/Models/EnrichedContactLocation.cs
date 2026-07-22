using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3EnrichedContact_location")]
public class EnrichedContactLocation {
    [JsonPropertyName("country")]
    public string? Country { get; set; }
    [JsonPropertyName("countryIso2")]
    public string? CountryISO2 { get; set; }
    [JsonPropertyName("state")]
    public string? State { get; set; }
    [JsonPropertyName("city")]
    public string? City { get; set; }
    [JsonPropertyName("continent")]
    public string? Continent { get; set; }
    [JsonPropertyName("coordinates")]
    public List<decimal>? Coordinates { get; set; }
    [JsonPropertyName("isEuContact")]
    public bool? IsEUContact { get; set; }
}
