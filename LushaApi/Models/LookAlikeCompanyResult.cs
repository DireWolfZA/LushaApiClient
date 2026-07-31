using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3LookAlikeCompanyResult")]
public class LookAlikeCompanyResult {
    [JsonPropertyName("id")]
    public string? ID { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }
    [JsonPropertyName("employeeCount")]
    public LookAlikeCompanyResultEmployeeCount? EmployeeCount { get; set; }
    [JsonPropertyName("industry")]
    public string? Industry { get; set; }
    [JsonPropertyName("location")]
    public LookAlikeCompanyResultLocation? Location { get; set; }
    [JsonPropertyName("socialLinks")]
    public LookAlikeCompanyResultSocialLinks? SocialLinks { get; set; }
}
