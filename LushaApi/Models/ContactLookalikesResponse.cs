using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "ContactLookalikesResponse")]
public class ContactLookalikesResponse {
    [JsonPropertyName("dedupeSessionId")]
    public required Guid DedupeSessionID { get; set; }
    [JsonPropertyName("results")]
    public required List<LookAlikeContactResult> Results { get; set; }
    [JsonPropertyName("meta")]
    public required ContactLookalikesMeta Meta { get; set; }
    [JsonPropertyName("billing")]
    public Billing? Billing { get; set; }
}
