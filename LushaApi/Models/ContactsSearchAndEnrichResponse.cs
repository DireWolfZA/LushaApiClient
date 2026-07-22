using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ContactsSearchAndEnrichResponse")]
public class ContactsSearchAndEnrichResponse {
    [JsonPropertyName("requestId")]
    public Guid? RequestID { get; set; }
    [JsonPropertyName("results")]
    public List<SearchAndEnrichContactResult>? Results { get; set; }
    [JsonPropertyName("billing")]
    public Billing? Billing { get; set; }
}
