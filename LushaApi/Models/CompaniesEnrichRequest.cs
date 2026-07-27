using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompaniesEnrichRequest")]
public class CompaniesEnrichRequest {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RevealEnum {
        [JsonStringEnumMemberName("employeesByDepartment")]
        EmployeesByDepartment = 1,
        [JsonStringEnumMemberName("employeesByLocation")]
        EmployeesByLocation = 2,
        [JsonStringEnumMemberName("employeesBySeniority")]
        EmployeesBySeniority = 3,
        [JsonStringEnumMemberName("competitors")]
        Competitors = 4,
        [JsonStringEnumMemberName("intent")]
        Intent = 5
    }

    /// <summary>
    /// Company IDs from search results (strings)
    /// </summary>
    [JsonPropertyName("ids")]
    public required List<string> IDs { get; set; }
    /// <summary>
    /// Additional data fields to reveal. Each field is charged separately per result.
    /// <br />- <see cref="RevealEnum.EmployeesByDepartment"/> — breakdown of employees by department
    /// <br />- <see cref="RevealEnum.EmployeesByLocation"/> — breakdown of employees by country/state
    /// <br />- <see cref="RevealEnum.EmployeesBySeniority"/> — breakdown of employees by seniority level
    /// <br />- <see cref="RevealEnum.Competitors"/> — list of competitor company IDs
    /// <br />- <see cref="RevealEnum.Intent"/> — buyer intent topics
    /// <br />Example: [&quot;employeesByDepartment&quot;,&quot;employeesByLocation&quot;,&quot;employeesBySeniority&quot;,&quot;competitors&quot;,&quot;intent&quot;]
    /// </summary>
    [JsonPropertyName("reveal")]
    public List<RevealEnum>? Reveal { get; set; }
}
