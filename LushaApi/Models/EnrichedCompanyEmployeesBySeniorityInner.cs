using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3EnrichedCompany_employeesBySeniority_inner")]
public class EnrichedCompanyEmployeesBySeniorityInner {
    /// <param name="seniority">Seniority level.</param>
    /// <param name="count">Number of employees at this seniority level.</param>
    public EnrichedCompanyEmployeesBySeniorityInner(string? seniority = null, int? count = null) {
        this.Seniority = seniority;
        this.Count = count;
    }

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
