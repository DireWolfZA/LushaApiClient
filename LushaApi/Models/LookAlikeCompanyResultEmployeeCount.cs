using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3LookAlikeCompanyResult_employeeCount")]
public class LookAlikeCompanyResultEmployeeCount {
    [JsonPropertyName("exact")]
    public int? Exact { get; set; }
}
