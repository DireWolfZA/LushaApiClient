using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3PaginationRequest")]
public class PaginationRequest {
    [JsonPropertyName("page")]
    public required int Page { get; set; }
    [JsonPropertyName("size")]
    public required int Size { get; set; }
}
