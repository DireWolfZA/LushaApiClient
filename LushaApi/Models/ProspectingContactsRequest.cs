using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ProspectingContactsRequest")]
public class ProspectingContactsRequest {
    [JsonPropertyName("pagination")]
    public required PaginationRequest Pagination { get; set; }
    [JsonPropertyName("filters")]
    public required ProspectingContactFilters Filters { get; set; }
    [JsonPropertyName("options")]
    public ProspectingContactsRequestOptions? Options { get; set; }
}
