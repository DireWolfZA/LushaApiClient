using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

/// <summary>
/// North American Industry Classification System (NAICS) code
/// </summary>
[DataContract(Name = "V3NaicsCode")]
public class NAICSCode {
    public NAICSCode(int? code = null, string? description = null) {
        this.Code = code;
        this.Description = description;
    }

    [JsonPropertyName("code")]
    public int? Code { get; set; }
    [JsonPropertyName("description")]
    public string? Description { get; set; }
}
