using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3EnrichedContactCompanyRef")]
public class EnrichedContactCompanyRef {
    public EnrichedContactCompanyRef(string? id = null, string? name = null, string? domain = null, string? industry = null) {
        this.ID = id;
        this.Name = name;
        this.Domain = domain;
        this.Industry = industry;
    }

    [JsonPropertyName("id")]
    public string? ID { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }
    [JsonPropertyName("industry")]
    public string? Industry { get; set; }
}
