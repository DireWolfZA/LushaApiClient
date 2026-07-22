using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3EnrichedCompany_revenueRange")]
public class EnrichedCompanyRevenueRange {
    public EnrichedCompanyRevenueRange(decimal? min = null, decimal? max = null) {
        this.Min = min;
        this.Max = max;
    }

    [JsonPropertyName("min")]
    public decimal? Min { get; set; }
    [JsonPropertyName("max")]
    public decimal? Max { get; set; }
}
