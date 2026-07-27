using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ProspectingCompaniesRequest_filters")]
public class ProspectingCompaniesRequestFilters {
    [JsonPropertyName("companies")]
    public required ProspectingCompaniesRequestFiltersCompanies Companies { get; set; }
}
