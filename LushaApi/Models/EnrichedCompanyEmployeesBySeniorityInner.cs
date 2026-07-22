using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3EnrichedCompany_employeesBySeniority_inner")]
public class EnrichedCompanyEmployeesBySeniorityInner {
    /// <summary>
    /// Seniority level
    /// </summary>
    [JsonPropertyName("seniority")]
    public string? Seniority { get; set; }
    /// <summary>
    /// Number of employees at this seniority level
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }
}
