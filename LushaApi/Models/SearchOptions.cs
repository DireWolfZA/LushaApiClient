using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

/// <summary>
/// Additional options for search requests
/// </summary>
[DataContract(Name = "V3SearchOptions")]
public class SearchOptions {
    /// <param name="includePartialProfiles">Include partial profiles in results.</param>
    public SearchOptions(bool includePartialProfiles) {
        this.IncludePartialProfiles = includePartialProfiles;
    }

    /// <summary>
    /// Include partial profiles in results
    /// </summary>
    [JsonPropertyName("includePartialProfiles")]
    public bool IncludePartialProfiles { get; set; }
}
