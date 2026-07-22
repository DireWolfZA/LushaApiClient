using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ContactsSearchRequest")]
public class ContactsSearchRequest {
    [JsonPropertyName("contacts")]
    public required List<ContactSearchItem> Contacts { get; set; }
    [JsonPropertyName("options")]
    public SearchOptions? Options { get; set; }
    [JsonPropertyName("signals")]
    public ContactSignals? Signals { get; set; }
}
