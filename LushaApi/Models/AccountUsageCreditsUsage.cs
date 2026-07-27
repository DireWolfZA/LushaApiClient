using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "CreditsUsage")]
public class AccountUsageCreditsUsage {
    [JsonPropertyName("total")]
    public decimal? Total { get; set; }
    [JsonPropertyName("used")]
    public decimal? Used { get; set; }
    [JsonPropertyName("remaining")]
    public decimal? Remaining { get; set; }
}
