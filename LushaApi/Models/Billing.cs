using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

/// <summary>
/// Credit usage summary for a V3 API request
/// </summary>
[DataContract(Name = "V3Billing")]
public class Billing {
    /// <summary>
    /// Initializes a new instance of the <see cref="Billing" /> class.
    /// </summary>
    /// <param name="creditsCharged">Total credits charged for this request.</param>
    /// <param name="resultsReturned">Number of successful results returned.</param>
    public Billing(int? creditsCharged = null, int? resultsReturned = null) {
        this.CreditsCharged = creditsCharged;
        this.ResultsReturned = resultsReturned;
    }

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
