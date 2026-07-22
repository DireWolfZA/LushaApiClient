using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

/// <summary>
/// Additional options for search requests
/// </summary>
[DataContract(Name = "V3SearchOptions")]
public class SearchOptions {
    /// <summary>
    /// Include partial profiles in results
    /// </summary>
    [JsonPropertyName("includePartialProfiles")]
    public required bool IncludePartialProfiles { get; set; }
}
