using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3LookAlikeContactResult")]
public class LookAlikeContactResult {
    [JsonPropertyName("id")]
    public string? ID { get; set; }
    [JsonPropertyName("firstName")]
    public string? FirstName { get; set; }
    [JsonPropertyName("lastName")]
    public string? LastName { get; set; }
    [JsonPropertyName("socialLinks")]
    public LookAlikeContactResultSocialLinks? SocialLinks { get; set; }
    [JsonPropertyName("company")]
    public ContactPreviewCompany? Company { get; set; }
    [JsonPropertyName("jobTitle")]
    public LookAlikeContactResultJobTitle? JobTitle { get; set; }
    [JsonPropertyName("location")]
    public ContactPreviewLocation? Location { get; set; }
}
