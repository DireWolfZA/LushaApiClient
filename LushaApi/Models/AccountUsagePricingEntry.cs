using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "PricingEntry")]
public class AccountUsagePricingEntry {
    [JsonPropertyName("credits")]
    public decimal? Credits { get; set; }
    [JsonPropertyName("perQuantity")]
    public decimal? PerQuantity { get; set; }
}
