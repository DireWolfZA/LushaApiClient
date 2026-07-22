using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

/// <summary>
/// Standard Industrial Classification (SIC) code
/// </summary>
[DataContract(Name = "V3SicCode")]
public class SICCode {
    [JsonPropertyName("code")]
    public int? Code { get; set; }
    [JsonPropertyName("description")]
    public string? Description { get; set; }
}
