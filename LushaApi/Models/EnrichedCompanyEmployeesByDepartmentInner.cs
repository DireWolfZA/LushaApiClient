using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3EnrichedCompany_employeesByDepartment_inner")]
public class EnrichedCompanyEmployeesByDepartmentInner {
    /// <summary>
    /// Department name
    /// </summary>
    [JsonPropertyName("department")]
    public string? Department { get; set; }
    /// <summary>
    /// Number of employees in this department
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }
}
