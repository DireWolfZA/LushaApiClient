using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ContactSignalsDto")]
public class ContactSignals {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypesEnum {
        [JsonStringEnumMemberName("allSignals")]
        AllSignals = 1,
        [JsonStringEnumMemberName("promotion")]
        Promotion = 2,
        [JsonStringEnumMemberName("companyChange")]
        CompanyChange = 3
    }

    [JsonPropertyName("types")]
    public required List<TypesEnum> Types { get; set; }
    [JsonPropertyName("startDate")]
    public DateOnly? StartDate { get; set; }
    [JsonPropertyName("maxResultsPerSignal")]
    public int? MaxResultsPerSignal { get; set; }
}
