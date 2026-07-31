using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "ContactIdentifiersBatch")]
public class ContactIdentifiersBatch {
    [JsonPropertyName("linkedinUrls")]
    public List<string>? LinkedInUrls { get; set; }
    [JsonPropertyName("contacts")]
    public List<ContactItem>? Contacts { get; set; }
    [JsonPropertyName("emails")]
    public List<string>? Emails { get; set; }
    [JsonPropertyName("ids")]
    public List<string>? IDs { get; set; }
    [Obsolete("Use " + nameof(IDs) + " instead.")]
    [JsonPropertyName("contactIds")]
    public List<int>? ContactIDs { get; set; }
}
