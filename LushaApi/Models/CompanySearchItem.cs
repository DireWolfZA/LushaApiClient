using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompanySearchItem")]
public class CompanySearchItem {
    [JsonPropertyName("clientReferenceId")]
    public string? ClientReferenceID { get; set; }
    [JsonPropertyName("id")]
    public string? ID { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }
}
