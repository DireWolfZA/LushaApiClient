using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ProspectingContactFilters_companies")]
public class ProspectingContactFiltersCompanies {
    [JsonPropertyName("include")]
    public CompanyFilterCriteria? Include { get; set; }
    [JsonPropertyName("exclude")]
    public CompanyFilterCriteria? Exclude { get; set; }
}
