using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3PaginationResponse")]
public class PaginationResponse {
    [JsonPropertyName("page")]
    public int? Page { get; set; }
    [JsonPropertyName("size")]
    public int? Size { get; set; }
    [JsonPropertyName("total")]
    public int? Total { get; set; }
}
