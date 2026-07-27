using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompanyFilterCriteria_funding")]
public class CompanyFilterCriteriaFunding {
    [JsonPropertyName("isIpo")]
    public bool? IsIPO { get; set; }
    [JsonPropertyName("ranges")]
    public List<Range>? Ranges { get; set; }
    [JsonPropertyName("types")]
    public List<string>? Types { get; set; }
    [JsonPropertyName("investors")]
    public List<string>? Investors { get; set; }
}
