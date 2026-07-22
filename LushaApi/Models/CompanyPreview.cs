using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompanyPreview")]
public class CompanyPreview {
    [JsonPropertyName("clientReferenceId")]
    public string? ClientReferenceID { get; set; }
    [JsonPropertyName("id")]
    public string? ID { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }
    [JsonPropertyName("employeeCount")]
    public CompanyPreviewEmployeeCount? EmployeeCount { get; set; }
    [JsonPropertyName("industry")]
    public string? Industry { get; set; }
    [JsonPropertyName("location")]
    public CompanyPreviewLocation? Location { get; set; }
    [JsonPropertyName("socialLinks")]
    public CompanyPreviewSocialLinks? SocialLinks { get; set; }
    /// <summary>
    /// Available data points that can be revealed via Enrich Companies. Includes base firmographic fields plus new revealable fields: employeesByDepartment, employeesByLocation, employeesBySeniority, competitors, businessModel, phones, emails, keywords, socialLinks. 
    /// </summary>
    [JsonPropertyName("has")]
    public List<string>? Has { get; set; }
    /// <summary>
    /// Data fields that can be revealed via Enrich Companies, with the credit cost per field. A cost of 0 means the field has already been revealed for this account. 
    /// </summary>
    [JsonPropertyName("canReveal")]
    public List<CanRevealItem>? CanReveal { get; set; }
    [JsonPropertyName("signalTypes")]
    public List<string>? SignalTypes { get; set; }
    [JsonPropertyName("error")]
    public ItemError? Error { get; set; }
}
