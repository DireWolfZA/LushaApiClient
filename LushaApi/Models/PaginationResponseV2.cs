using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "PaginationResponse")]
public class PaginationResponseV2 {
    [JsonPropertyName("total")]
    public required int Total { get; set; }
    [JsonPropertyName("limit")]
    public int? Limit { get; set; }
    [JsonPropertyName("offset")]
    public int? Offset { get; set; }
    [JsonPropertyName("hasMore")]
    public required bool HasMore { get; set; }
}
