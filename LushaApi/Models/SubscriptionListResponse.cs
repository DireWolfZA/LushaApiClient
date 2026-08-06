using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "SubscriptionListResponse")]
public class SubscriptionListResponse {
    [JsonPropertyName("data")]
    public required List<SubscriptionWithoutSecret> Data { get; set; }
    [JsonPropertyName("pagination")]
    public required PaginationResponseV2 Pagination { get; set; }
}
