using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

/// <summary>
/// Indicates a data type that can be revealed and its credit cost
/// </summary>
[DataContract(Name = "V3CanRevealItem")]
public class CanRevealItem {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FieldEnum {
        [EnumMember(Value = "emails")]
        Emails = 1,
        [EnumMember(Value = "phones")]
        Phones = 2
    }

    /// <param name="credits">Credit cost (0 when already revealed for this account).</param>
    public CanRevealItem(FieldEnum? field = null, int? credits = null) {
        this.Field = field;
        this.Credits = credits;
    }

    [JsonPropertyName("field")]
    public FieldEnum? Field { get; set; }
    /// <summary>
    /// Credit cost (0 when already revealed for this account)
    /// </summary>
    [JsonPropertyName("credits")]
    public int? Credits { get; set; }
}
