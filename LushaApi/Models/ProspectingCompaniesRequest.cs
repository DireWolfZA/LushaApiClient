using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ProspectingCompaniesRequest")]
public class ProspectingCompaniesRequest {
    [JsonPropertyName("pagination")]
    public required PaginationRequest Pagination { get; set; }
    [JsonPropertyName("filters")]
    public required ProspectingCompaniesRequestFilters Filters { get; set; }
    [JsonPropertyName("options")]
    public ProspectingCompaniesRequestOptions? Options { get; set; }
}
