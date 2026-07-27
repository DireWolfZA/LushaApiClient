using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "PlanInfo")]
public class AccountUsagePlanInfo {
    [JsonPropertyName("category")]
    public string? Category { get; set; }
    [JsonPropertyName("renewalType")]
    public string? RenewalType { get; set; }
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }
    [JsonPropertyName("endDate")]
    public DateTime? EndDate { get; set; }
}
