using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3EnrichedCompany_employeesByLocation_inner")]
public class EnrichedCompanyEmployeesByLocationInner {
    /// <param name="country">Country name.</param>
    /// <param name="state">State or region (null when not available).</param>
    /// <param name="count">Number of employees in this location.</param>
    public EnrichedCompanyEmployeesByLocationInner(string? country = null, string? state = null, int? count = null) {
        this.Country = country;
        this.State = state;
        this.Count = count;
    }

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
