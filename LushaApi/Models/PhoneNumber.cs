using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3PhoneNumber")]
public class PhoneNumber {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeEnum {
        [JsonStringEnumMemberName("mobile")]
        Mobile = 1,
        [JsonStringEnumMemberName("direct")]
        Direct = 2,
        [JsonStringEnumMemberName("work")]
        Work = 3,
        [JsonStringEnumMemberName("unknown")]
        Unknown = 4
    }

    [JsonPropertyName("number")]
    public string? Number { get; set; }
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    [JsonPropertyName("doNotCall")]
    public bool? DoNotCall { get; set; }
    [JsonPropertyName("countryIso2")]
    public string? CountryISO2 { get; set; }
    [JsonPropertyName("updateDate")]
    public DateOnly? UpdateDate { get; set; }
    [JsonPropertyName("dataSource")]
    public string? DataSource { get; set; }
}
