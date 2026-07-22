using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompanyPreview")]
public class CompanyPreview {
    /// <param name="has">Available data points that can be revealed via Enrich Companies. Includes base firmographic fields plus new revealable fields: employeesByDepartment, employeesByLocation, employeesBySeniority, competitors, businessModel, phones, emails, keywords, socialLinks. .</param>
    /// <param name="canReveal">Data fields that can be revealed via Enrich Companies, with the credit cost per field. A cost of 0 means the field has already been revealed for this account. .</param>
    public CompanyPreview(
        string? clientReferenceID = null, string? id = null, string? name = null, string? domain = null, CompanyPreviewEmployeeCount? employeeCount = null,
        string? industry = null, CompanyPreviewLocation? location = null, CompanyPreviewSocialLinks? socialLinks = null, List<string>? has = null,
        List<CanRevealItem>? canReveal = null, List<string>? signalTypes = null, ItemError? error = null
    ) {
        this.ClientReferenceID = clientReferenceID;
        this.ID = id;
        this.Name = name;
        this.Domain = domain;
        this.EmployeeCount = employeeCount;
        this.Industry = industry;
        this.Location = location;
        this.SocialLinks = socialLinks;
        this.Has = has;
        this.CanReveal = canReveal;
        this.SignalTypes = signalTypes;
        this.Error = error;
    }

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
