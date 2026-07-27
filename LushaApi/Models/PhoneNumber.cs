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
    /// <summary>
    /// Should be <see cref="DateOnly"/>, but netstandard2.0 doesn't include it
    /// </summary>
    [JsonPropertyName("updateDate")]
    public DateTimeOffset? UpdateDate { get; set; }
}
