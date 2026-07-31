using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "ContactItem")]
public class ContactItem {
    [JsonPropertyName("firstName")]
    public required string FirstName { get; set; }
    [JsonPropertyName("lastName")]
    public required string LastName { get; set; }
    [JsonPropertyName("companyDomain")]
    public string? CompanyDomain { get; set; }
    [JsonPropertyName("companyName")]
    public string? CompanyName { get; set; }
}
