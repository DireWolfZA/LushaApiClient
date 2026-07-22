using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompanyPreview_location")]
public class CompanyPreviewLocation {
    public CompanyPreviewLocation(string? city = null, string? state = null, string? country = null, string? countryISO2 = null, string? continent = null) {
        this.City = city;
        this.State = state;
        this.Country = country;
        this.CountryISO2 = countryISO2;
        this.Continent = continent;
    }

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
