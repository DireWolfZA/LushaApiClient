using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ContactsSearchAndEnrichResponse")]
public class ContactsSearchAndEnrichResponse {
    public ContactsSearchAndEnrichResponse(Guid? requestId = null, List<SearchAndEnrichContactResult>? results = null, Billing? billing = null) {
        this.RequestId = requestId;
        this.Results = results;
        this.Billing = billing;
    }

    [JsonPropertyName("requestId")]
    public Guid? RequestId { get; set; }
    [JsonPropertyName("results")]
    public List<SearchAndEnrichContactResult>? Results { get; set; }
    [JsonPropertyName("billing")]
    public Billing? Billing { get; set; }
}
