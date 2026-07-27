using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ProspectingCompaniesRequest_options")]
public class ProspectingCompaniesRequestOptions {
    [JsonPropertyName("maxContactsPerCompany")]
    public int? MaxContactsPerCompany { get; set; }
    [JsonPropertyName("includePartialProfiles")]
    public bool? IncludePartialProfiles { get; set; }
}
