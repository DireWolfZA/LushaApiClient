using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ContactSearchItem")]
public class ContactSearchItem {
    [JsonPropertyName("clientReferenceId")]
    public string? ClientReferenceID { get; set; }
    [JsonPropertyName("id")]
    public string? ID { get; set; }
    [JsonPropertyName("linkedinUrl")]
    public string? LinkedInURL { get; set; }
    [JsonPropertyName("email")]
    public string? Email { get; set; }
    [JsonPropertyName("firstName")]
    public string? FirstName { get; set; }
    [JsonPropertyName("lastName")]
    public string? LastName { get; set; }
    [JsonPropertyName("companyName")]
    public string? CompanyName { get; set; }
    [JsonPropertyName("companyDomain")]
    public string? CompanyDomain { get; set; }
}
