using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "FilterTypesDiscoveryResponse")]
public class FilterTypesDiscoveryResponse {
    [JsonPropertyName("availableFilters")]
    public List<FilterTypesDiscoveryResponseAvailableFiltersInner>? AvailableFilters { get; set; }
}
