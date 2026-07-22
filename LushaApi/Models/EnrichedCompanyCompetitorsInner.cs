using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3EnrichedCompany_competitors_inner")]
public class EnrichedCompanyCompetitorsInner {
    /// <summary>
    /// Lusha company ID of the competitor
    /// </summary>
    [JsonPropertyName("id")]
    public string? ID { get; set; }
    /// <summary>
    /// Company name of the competitor
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// Primary domain of the competitor
    /// </summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }
}
