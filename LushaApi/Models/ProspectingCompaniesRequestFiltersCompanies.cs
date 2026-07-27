using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ProspectingCompaniesRequest_filters_companies")]
public class ProspectingCompaniesRequestFiltersCompanies {
    [JsonPropertyName("include")]
    public required CompanyProspectingFilters Include { get; set; }
    [JsonPropertyName("exclude")]
    public CompanyProspectingFilters? Exclude { get; set; }
}
