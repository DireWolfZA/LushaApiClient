using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3EnrichedCompany_employeesByDepartment_inner")]
public class EnrichedCompanyEmployeesByDepartmentInner {
    /// <param name="department">Department name.</param>
    /// <param name="count">Number of employees in this department.</param>
    public EnrichedCompanyEmployeesByDepartmentInner(string? department = null, int? count = null) {
        this.Department = department;
        this.Count = count;
    }

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
