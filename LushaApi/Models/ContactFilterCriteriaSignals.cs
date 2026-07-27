using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ContactFilterCriteria_signals")]
public class ContactFilterCriteriaSignals {
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
    public List<TypesEnum>? Types { get; set; }
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }
}
