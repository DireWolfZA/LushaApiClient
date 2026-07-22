using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ContactSignalsDto")]
public class ContactSignals {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypesEnum {
        [EnumMember(Value = "allSignals")]
        AllSignals = 1,
        [EnumMember(Value = "promotion")]
        Promotion = 2,
        [EnumMember(Value = "companyChange")]
        CompanyChange = 3
    }

    [JsonPropertyName("types")]
    public required List<TypesEnum> Types { get; set; }
    /// <summary>
    /// Should be <see cref="DateOnly"/>, but netstandard2.0 doesn't include it
    /// </summary>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }
    [JsonPropertyName("maxResultsPerSignal")]
    public int? MaxResultsPerSignal { get; set; }
}
