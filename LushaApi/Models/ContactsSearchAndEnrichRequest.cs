using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ContactsSearchAndEnrichRequest")]
public class ContactsSearchAndEnrichRequest {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RevealEnum {
        [EnumMember(Value = "emails")]
        Emails = 1,
        [EnumMember(Value = "phones")]
        Phones = 2
    }

    public ContactsSearchAndEnrichRequest(List<ContactSearchItem> contacts, List<RevealEnum>? reveal = null, SearchOptions? options = null) {
        this.Contacts = contacts ?? throw new ArgumentNullException("contacts is a required property for V3ContactsSearchAndEnrichRequest and cannot be null");
        this.Reveal = reveal;
        this.Options = options;
    }

    [JsonPropertyName("contacts")]
    public List<ContactSearchItem> Contacts { get; set; }
    [JsonPropertyName("reveal")]
    public List<RevealEnum>? Reveal { get; set; }
    [JsonPropertyName("options")]
    public SearchOptions? Options { get; set; }
}
