using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

/// <summary>
/// Numeric range filter
/// </summary>
[DataContract(Name = "V3Range")]
public class Range {
    [JsonPropertyName("min")]
    public int? Min { get; set; }
    [JsonPropertyName("max")]
    public int? Max { get; set; }
}
