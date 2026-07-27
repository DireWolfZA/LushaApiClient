using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ContactFilterCriteria")]
public class ContactFilterCriteria {
    [JsonPropertyName("names")]
    public List<string>? Names { get; set; }
    [JsonPropertyName("jobTitles")]
    public List<string>? JobTitles { get; set; }
    [JsonPropertyName("jobTitlesExactMatch")]
    public List<string>? JobTitlesExactMatch { get; set; }
    [JsonPropertyName("normalizedJobTitles")]
    public List<string>? NormalizedJobTitles { get; set; }
    [JsonPropertyName("searchText")]
    public string? SearchText { get; set; }
    [JsonPropertyName("countries")]
    public List<string>? Countries { get; set; }
    [JsonPropertyName("locations")]
    public List<Location>? Locations { get; set; }
    [JsonPropertyName("seniorityIds")]
    public List<int>? SeniorityIDs { get; set; }
    [JsonPropertyName("departments")]
    public List<string>? Departments { get; set; }
    [JsonPropertyName("linkedinUrls")]
    public List<string>? LinkedInURLs { get; set; }
    [JsonPropertyName("existingDataPoints")]
    public List<string>? ExistingDataPoints { get; set; }
    [JsonPropertyName("signals")]
    public ContactFilterCriteriaSignals? Signals { get; set; }
}
