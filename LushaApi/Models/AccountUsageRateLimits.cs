using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "RateLimits")]
public class AccountUsageRateLimits {
    [JsonPropertyName("daily")]
    public AccountUsageRateLimitTier? Daily { get; set; }
    [JsonPropertyName("hourly")]
    public AccountUsageRateLimitTier? Hourly { get; set; }
    [JsonPropertyName("minute")]
    public AccountUsageRateLimitTier? Minute { get; set; }
}
