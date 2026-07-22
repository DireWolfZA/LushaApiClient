using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompanyPreview_employeeCount")]
public class CompanyPreviewEmployeeCount {
    public CompanyPreviewEmployeeCount(int? exact = null, int? min = null, int? max = null) {
        this.Exact = exact;
        this.Min = min;
        this.Max = max;
    }

    [JsonPropertyName("exact")]
    public int? Exact { get; set; }
    [JsonPropertyName("min")]
    public int? Min { get; set; }
    [JsonPropertyName("max")]
    public int? Max { get; set; }
}
