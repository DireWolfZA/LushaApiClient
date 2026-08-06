using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "DecisionMakersRequest")]
public class DecisionMakersRequest {
    /// <summary>
    /// 1–N companies. Each entry must contain exactly one of `domain` or `id`.
    /// </summary>
    [JsonPropertyName("companies")]
    public required List<DecisionMakersCompanyInput> Companies { get; set; }
    [JsonPropertyName("pagination")]
    public PaginationRequest? Pagination { get; set; }
}
