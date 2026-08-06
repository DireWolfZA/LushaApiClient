using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "DecisionMakersCompanyInput")]
public class DecisionMakersCompanyInput {
    /// <summary>
    /// Company domain, resolved to a Lusha company ID server-side. Mutually exclusive with `id`.
    /// </summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }
    /// <summary>
    /// Encrypted Lusha company ID (`vN.…`); legacy numeric IDs accepted. Mutually exclusive with `domain`.
    /// </summary>
    [JsonPropertyName("id")]
    public string? ID { get; set; }
    /// <summary>
    /// Caller-supplied correlation token, echoed back on the matching result.
    /// </summary>
    [JsonPropertyName("clientReferenceId")]
    public string? ClientReferenceID { get; set; }
}
