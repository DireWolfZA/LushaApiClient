using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3EnrichedCompany_employeesByLocation_inner")]
public class EnrichedCompanyEmployeesByLocationInner {
    /// <summary>
    /// Country name
    /// </summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }
    /// <summary>
    /// State or region (null when not available)
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
    /// <summary>
    /// Number of employees in this location
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }
}
