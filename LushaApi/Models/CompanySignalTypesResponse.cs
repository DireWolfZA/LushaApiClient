using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "CompanySignalTypesResponse")]
public class CompanySignalTypesResponse {
    [JsonPropertyName("signalTypes")]
    public List<string>? SignalTypes { get; set; }
}
