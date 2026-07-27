using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3Location")]
public class Location {
    [JsonPropertyName("city")]
    public string? City { get; set; }
    [JsonPropertyName("state")]
    public string? State { get; set; }
    [JsonPropertyName("country")]
    public string? Country { get; set; }
    [JsonPropertyName("continent")]
    public string? Continent { get; set; }
    [JsonPropertyName("countryGrouping")]
    public string? CountryGrouping { get; set; }
}
