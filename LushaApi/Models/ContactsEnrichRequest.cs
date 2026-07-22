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

    [JsonPropertyName("ids")]
    public required List<string> IDs { get; set; }
    [JsonPropertyName("reveal")]
    public List<RevealEnum>? Reveal { get; set; }
}
