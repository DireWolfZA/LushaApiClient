using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ContactsSearchResponse")]
public class ContactsSearchResponse {
    [JsonPropertyName("requestId")]
    public Guid? RequestID { get; set; }
    [JsonPropertyName("results")]
    public List<ContactPreview>? Results { get; set; }
    [JsonPropertyName("billing")]
    public Billing? Billing { get; set; }
}
