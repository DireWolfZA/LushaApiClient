using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ContactsSearchResponse")]
public class ContactsSearchResponse {
    public ContactsSearchResponse(Guid? requestID = null, List<ContactPreview>? results = null, Billing? billing = null) {
        this.RequestID = requestID;
        this.Results = results;
        this.Billing = billing;
    }

    [JsonPropertyName("requestId")]
    public Guid? RequestID { get; set; }
    [JsonPropertyName("results")]
    public List<ContactPreview>? Results { get; set; }
    [JsonPropertyName("billing")]
    public Billing? Billing { get; set; }
}
