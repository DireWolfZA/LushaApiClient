using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "AccountUsageResponse")]
public class AccountUsageResponse {
    [JsonPropertyName("credits")]
    public AccountUsageCreditsUsage? Credits { get; set; }
    [JsonPropertyName("rateLimits")]
    public AccountUsageRateLimits? RateLimits { get; set; }
    [JsonPropertyName("plan")]
    public AccountUsagePlanInfo? Plan { get; set; }
    [JsonPropertyName("pricing")]
    public Dictionary<string, AccountUsagePricingEntry>? Pricing { get; set; }
}
