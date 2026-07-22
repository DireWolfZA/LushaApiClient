using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ContactsSearchRequest")]
public class ContactsSearchRequest {
    public ContactsSearchRequest(List<ContactSearchItem> contacts, SearchOptions? options, ContactSignals? signals) {
        this.Contacts = contacts ?? throw new ArgumentNullException("contacts is a required property for V3ContactsSearchRequest and cannot be null");
        this.Options = options;
        this.Signals = signals;
    }

    [JsonPropertyName("contacts")]
    public List<ContactSearchItem> Contacts { get; set; }
    [JsonPropertyName("options")]
    public SearchOptions? Options { get; set; }
    [JsonPropertyName("signals")]
    public ContactSignals? Signals { get; set; }
}
