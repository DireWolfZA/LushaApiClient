using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3LookAlikeContactResult_socialLinks")]
public class LookAlikeContactResultSocialLinks {
    [JsonPropertyName("linkedin")]
    public string? LinkedIn { get; set; }
}
