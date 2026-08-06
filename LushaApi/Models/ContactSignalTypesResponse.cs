using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "ContactSignalTypesResponse")]
public class ContactSignalTypesResponse {
    [JsonPropertyName("signalTypes")]
    public List<string>? SignalTypes { get; set; }
}
