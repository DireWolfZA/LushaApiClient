using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ContactsEnrichRequest")]
public class ContactsEnrichRequest {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RevealEnum {
        [JsonStringEnumMemberName("emails")]
        Emails = 1,
        [JsonStringEnumMemberName("phones")]
        Phones = 2
    }

    [JsonPropertyName("ids")]
    public required List<string> IDs { get; set; }
    [JsonPropertyName("reveal")]
    public List<RevealEnum>? Reveal { get; set; }
}
