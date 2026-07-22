using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3EnrichedCompany_competitors_inner")]
public class EnrichedCompanyCompetitorsInner {
    /// <param name="id">Lusha company ID of the competitor.</param>
    /// <param name="name">Company name of the competitor.</param>
    /// <param name="domain">Primary domain of the competitor.</param>
    public EnrichedCompanyCompetitorsInner(string? id = null, string? name = null, string? domain = null) {
        this.ID = id;
        this.Name = name;
        this.Domain = domain;
    }

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
