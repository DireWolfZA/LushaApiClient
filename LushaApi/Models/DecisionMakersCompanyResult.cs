using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "DecisionMakersCompanyResult")]
public class DecisionMakersCompanyResult {
    /// <summary>
    /// Echoed from the matching request entry.
    /// </summary>
    [JsonPropertyName("clientReferenceId")]
    public string? ClientReferenceID { get; set; }
    /// <summary>
    /// Encrypted Lusha company ID the decision makers belong to. Omitted on NOT_FOUND entries.
    /// </summary>
    [JsonPropertyName("companyId")]
    public string? CompanyID { get; set; }
    /// <summary>
    /// Requested domain, echoed back on a NOT_FOUND entry.
    /// </summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }
    /// <summary>
    /// Ranked decision makers, highest relevance first.
    /// </summary>
    [JsonPropertyName("decisionMakers")]
    public List<ContactPreview>? DecisionMakers { get; set; }
    /// <summary>
    /// Per-item error in a batch response
    /// </summary>
    [JsonPropertyName("error")]
    public ItemError? Error { get; set; }
}
