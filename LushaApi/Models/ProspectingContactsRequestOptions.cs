using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ProspectingContactsRequest_options")]
public class ProspectingContactsRequestOptions {
    [JsonPropertyName("maxContactsPerCompany")]
    public int? MaxContactsPerCompany { get; set; }
    [JsonPropertyName("includePartialProfiles")]
    public bool? IncludePartialProfiles { get; set; }
    [JsonPropertyName("excludeDnc")]
    public bool? ExcludeDNC { get; set; }
}
