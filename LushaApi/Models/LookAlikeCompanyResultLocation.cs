using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3LookAlikeCompanyResult_location")]
public class LookAlikeCompanyResultLocation {
    [JsonPropertyName("country")]
    public string? Country { get; set; }
    [JsonPropertyName("state")]
    public string? State { get; set; }
    [JsonPropertyName("city")]
    public string? City { get; set; }
}
