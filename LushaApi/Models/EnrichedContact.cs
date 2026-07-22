using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3EnrichedContact")]
public class EnrichedContact {
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
}
