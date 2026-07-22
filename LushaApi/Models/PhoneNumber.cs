using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3PhoneNumber")]
public class PhoneNumber {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeEnum {
        [EnumMember(Value = "mobile")]
        Mobile = 1,
        [EnumMember(Value = "direct")]
        Direct = 2,
        [EnumMember(Value = "work")]
        Work = 3,
        [EnumMember(Value = "unknown")]
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
