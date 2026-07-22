using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ContactsEnrichResponse")]
public class ContactsEnrichResponse {
    public ContactsEnrichResponse(Guid? requestID = null, List<EnrichedContact>? results = null, Billing? billing = null) {
        this.RequestID = requestID;
        this.Results = results;
        this.Billing = billing;
    }

    [JsonPropertyName("requestId")]
    public Guid? RequestID { get; set; }
    [JsonPropertyName("results")]
    public List<EnrichedContact>? Results { get; set; }
    [JsonPropertyName("billing")]
    public Billing? Billing { get; set; }
}
