using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3LookAlikeCompanyResult_socialLinks")]
public class LookAlikeCompanyResultSocialLinks {
    [JsonPropertyName("linkedin")]
    public string? LinkedIn { get; set; }
}
