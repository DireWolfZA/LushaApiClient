using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "CompanyIdentifiersBatch")]
public class CompanyIdentifiersBatch {
    [JsonPropertyName("domains")]
    public List<string>? Domains { get; set; }
    [JsonPropertyName("linkedinUrls")]
    public List<string>? LinkedInURLs { get; set; }
}
