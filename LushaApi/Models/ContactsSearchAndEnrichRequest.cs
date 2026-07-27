using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ContactsSearchAndEnrichRequest")]
public class ContactsSearchAndEnrichRequest {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RevealEnum {
        [JsonStringEnumMemberName("emails")]
        Emails = 1,
        [JsonStringEnumMemberName("phones")]
        Phones = 2
    }

    [JsonPropertyName("contacts")]
    public required List<ContactSearchItem> Contacts { get; set; }
    [JsonPropertyName("reveal")]
    public List<RevealEnum>? Reveal { get; set; }
    [JsonPropertyName("options")]
    public SearchOptions? Options { get; set; }
}
