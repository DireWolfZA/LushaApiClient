using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "ContactLookalikesRequest")]
public class ContactLookalikesRequest {
    [JsonPropertyName("dedupeSessionId")]
    public Guid? DedupeSessionID { get; set; }
    [JsonPropertyName("seeds")]
    public required ContactIdentifiersBatch Seeds { get; set; }
    [JsonPropertyName("exclude")]
    public ContactIdentifiersBatch? Exclude { get; set; }
    /// <summary>Default: 25</summary>
    [JsonPropertyName("limit")]
    public int? Limit { get; set; }
}
