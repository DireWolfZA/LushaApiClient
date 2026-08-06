using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "FilterTypesDiscoveryResponse_availableFilters_inner")]
public class FilterTypesDiscoveryResponseAvailableFiltersInner {
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }
    [JsonPropertyName("requiresQuery")]
    public bool? RequiresQuery { get; set; }
}
