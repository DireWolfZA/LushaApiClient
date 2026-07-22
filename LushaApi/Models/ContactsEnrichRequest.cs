using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ContactsEnrichRequest")]
public class ContactsEnrichRequest {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RevealEnum {
        [EnumMember(Value = "emails")]
        Emails = 1,
        [EnumMember(Value = "phones")]
        Phones = 2
    }

    public ContactsEnrichRequest(List<string> ids, List<RevealEnum>? reveal = null) {
        this.IDs = ids ?? throw new ArgumentNullException("ids is a required property for V3ContactsEnrichRequest and cannot be null");
        this.Reveal = reveal;
    }

    [JsonPropertyName("ids")]
    public List<string> IDs { get; set; }
    [JsonPropertyName("reveal")]
    public List<RevealEnum>? Reveal { get; set; }
}
