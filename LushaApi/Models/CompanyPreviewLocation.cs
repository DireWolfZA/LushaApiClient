using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompanyPreview_location")]
public class CompanyPreviewLocation {
    [JsonPropertyName("city")]
    public string? City { get; set; }
    [JsonPropertyName("state")]
    public string? State { get; set; }
    [JsonPropertyName("country")]
    public string? Country { get; set; }
    [JsonPropertyName("countryIso2")]
    public string? CountryISO2 { get; set; }
    [JsonPropertyName("continent")]
    public string? Continent { get; set; }
}
