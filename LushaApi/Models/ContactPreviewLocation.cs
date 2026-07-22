using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ContactPreview_location")]
public class ContactPreviewLocation {
    public ContactPreviewLocation(string? country = null, string? state = null, string? city = null) {
        this.Country = country;
        this.State = state;
        this.City = city;
    }

    [JsonPropertyName("country")]
    public string? Country { get; set; }
    [JsonPropertyName("state")]
    public string? State { get; set; }
    [JsonPropertyName("city")]
    public string? City { get; set; }
}
