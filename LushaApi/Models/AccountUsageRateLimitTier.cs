using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "RateLimitTier")]
public class AccountUsageRateLimitTier {
    [JsonPropertyName("limit")]
    public decimal? Limit { get; set; }
    [JsonPropertyName("used")]
    public decimal? Used { get; set; }
    [JsonPropertyName("remaining")]
    public decimal? Remaining { get; set; }
    [JsonPropertyName("resetsAt")]
    public DateTime? ResetsAt { get; set; }
}
