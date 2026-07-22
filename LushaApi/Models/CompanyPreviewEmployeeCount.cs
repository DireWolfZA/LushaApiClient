using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompanyPreview_employeeCount")]
public class CompanyPreviewEmployeeCount {
    [JsonPropertyName("exact")]
    public int? Exact { get; set; }
    [JsonPropertyName("min")]
    public int? Min { get; set; }
    [JsonPropertyName("max")]
    public int? Max { get; set; }
}
