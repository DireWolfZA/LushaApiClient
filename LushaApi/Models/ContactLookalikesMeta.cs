using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "ContactLookalikesMeta")]
public class ContactLookalikesMeta {
    [JsonPropertyName("returned")]
    public required int Returned { get; set; }
    [JsonPropertyName("hasMore")]
    public required bool HasMore { get; set; }
}
