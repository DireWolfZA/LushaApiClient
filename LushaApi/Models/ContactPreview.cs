using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ContactPreview")]
public class ContactPreview {
    [JsonPropertyName("clientReferenceId")]
    public string? ClientReferenceID { get; set; }
    [JsonPropertyName("id")]
    public string? ID { get; set; }
    [JsonPropertyName("firstName")]
    public string? FirstName { get; set; }
    [JsonPropertyName("lastName")]
    public string? LastName { get; set; }
    [JsonPropertyName("jobTitle")]
    public ContactPreviewJobTitle? JobTitle { get; set; }
    [JsonPropertyName("company")]
    public ContactPreviewCompany? Company { get; set; }
    [JsonPropertyName("location")]
    public ContactPreviewLocation? Location { get; set; }
    [JsonPropertyName("socialLinks")]
    public ContactPreviewSocialLinks? SocialLinks { get; set; }
    [JsonPropertyName("has")]
    public List<string>? Has { get; set; }
    [JsonPropertyName("canReveal")]
    public List<CanRevealItem>? CanReveal { get; set; }
    [JsonPropertyName("signalTypes")]
    public List<string>? SignalTypes { get; set; }
    [JsonPropertyName("error")]
    public ItemError? Error { get; set; }
}
