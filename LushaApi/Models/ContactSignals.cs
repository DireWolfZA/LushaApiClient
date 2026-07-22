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

    public ContactSignals(List<TypesEnum> types, DateTime startDate, int maxResultsPerSignal) {
        this.Types = types ?? throw new ArgumentNullException("types is a required property for V3ContactSignalsDto and cannot be null");
        this.StartDate = startDate;
        this.MaxResultsPerSignal = maxResultsPerSignal;
    }

    [JsonPropertyName("types")]
    public List<TypesEnum> Types { get; set; }
    /// <summary>
    /// Should be <see cref="DateOnly"/>, but netstandard2.0 doesn't include it
    /// </summary>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }
    [JsonPropertyName("maxResultsPerSignal")]
    public int? MaxResultsPerSignal { get; set; }
}
