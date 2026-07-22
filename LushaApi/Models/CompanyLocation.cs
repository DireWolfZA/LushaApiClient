using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompanyLocation")]
public class CompanyLocation {
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
    /// <summary>
    /// Postal/ZIP code (present on HQ location when available)
    /// </summary>
    [JsonPropertyName("zipCode")]
    public string? ZipCode { get; set; }
}
