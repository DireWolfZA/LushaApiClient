using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

/// <summary>
/// Credit usage summary for a V3 API request
/// </summary>
[DataContract(Name = "V3Billing")]
public class Billing {
    /// <summary>
    /// Total credits charged for this request
    /// </summary>
    [JsonPropertyName("creditsCharged")]
    public int? CreditsCharged { get; set; }
    /// <summary>
    /// Number of successful results returned
    /// </summary>
    [JsonPropertyName("resultsReturned")]
    public int? ResultsReturned { get; set; }
}
