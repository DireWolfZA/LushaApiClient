using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3SearchAndEnrichContactResult")]
public class SearchAndEnrichContactResult {
    public SearchAndEnrichContactResult(
        string? id = null, string? firstName = null, string? lastName = null, string? fullName = null,
        ContactPreviewJobTitle? jobTitle = null, EnrichedContactLocation? location = null, List<ContactTag>? tags = null,
        List<EmailAddress>? emails = null, List<PhoneNumber>? phones = null, EnrichedContactCompanyRef? company = null,
        EnrichedContactSocialLinks? socialLinks = null, List<EnrichedContactPreviousEmploymentInner>? previousEmployment = null,
        DateTimeOffset? updateDate = null, ItemError? error = null, string? clientReferenceID = null
    ) {
        this.ID = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.FullName = fullName;
        this.JobTitle = jobTitle;
        this.Location = location;
        this.Tags = tags;
        this.Emails = emails;
        this.Phones = phones;
        this.Company = company;
        this.SocialLinks = socialLinks;
        this.PreviousEmployment = previousEmployment;
        this.UpdateDate = updateDate;
        this.Error = error;
        this.ClientReferenceID = clientReferenceID;
    }

    [JsonPropertyName("id")]
    public string? ID { get; set; }
    [JsonPropertyName("firstName")]
    public string? FirstName { get; set; }
    [JsonPropertyName("lastName")]
    public string? LastName { get; set; }
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }
    [JsonPropertyName("jobTitle")]
    public ContactPreviewJobTitle? JobTitle { get; set; }
    [JsonPropertyName("location")]
    public EnrichedContactLocation? Location { get; set; }
    [JsonPropertyName("tags")]
    public List<ContactTag>? Tags { get; set; }
    [JsonPropertyName("emails")]
    public List<EmailAddress>? Emails { get; set; }
    [JsonPropertyName("phones")]
    public List<PhoneNumber>? Phones { get; set; }
    [JsonPropertyName("company")]
    public EnrichedContactCompanyRef? Company { get; set; }
    [JsonPropertyName("socialLinks")]
    public EnrichedContactSocialLinks? SocialLinks { get; set; }
    [JsonPropertyName("previousEmployment")]
    public List<EnrichedContactPreviousEmploymentInner>? PreviousEmployment { get; set; }
    /// <summary>
    /// Should be <see cref="DateOnly"/>, but netstandard2.0 doesn't include it
    /// </summary>
    [JsonPropertyName("updateDate")]
    public DateTimeOffset? UpdateDate { get; set; }
    [JsonPropertyName("error")]
    public ItemError? Error { get; set; }
    [JsonPropertyName("clientReferenceId")]
    public string? ClientReferenceID { get; set; }
}
