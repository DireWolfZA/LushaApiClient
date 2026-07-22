using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3EmailAddress")]
public class EmailAddress {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeEnum {
        [EnumMember(Value = "work")]
        Work = 1,
        [EnumMember(Value = "private")]
        Private = 2,
        [EnumMember(Value = "unknown")]
        Unknown = 3
    }

    [JsonPropertyName("email")]
    public string? Email { get; set; }
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    [JsonPropertyName("confidence")]
    public string? Confidence { get; set; }
    /// <summary>
    /// Should be <see cref="DateOnly"/>, but netstandard2.0 doesn't include it
    /// </summary>
    [JsonPropertyName("updateDate")]
    public DateTimeOffset? UpdateDate { get; set; }
}
