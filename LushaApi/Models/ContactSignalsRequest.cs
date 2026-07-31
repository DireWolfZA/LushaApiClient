using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ContactSignalsRequest")]
public class ContactSignalsRequest {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SignalTypesEnum {
        [JsonStringEnumMemberName("allSignals")]
        AllSignals = 1,
        [JsonStringEnumMemberName("promotion")]
        Promotion = 2,
        [JsonStringEnumMemberName("companyChange")]
        CompanyChange = 3
    }

    [JsonPropertyName("ids")]
    public required List<string> IDs { get; set; }
    [JsonPropertyName("signalTypes")]
    public required List<SignalTypesEnum> SignalTypes { get; set; }
    [JsonPropertyName("startDate")]
    public DateOnly? StartDate { get; set; }
    [JsonPropertyName("maxResultsPerSignal")]
    public int? MaxResultsPerSignal { get; set; }
}
