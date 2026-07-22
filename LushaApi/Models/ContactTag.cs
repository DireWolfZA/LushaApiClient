using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ContactTag")]
public class ContactTag {
    public ContactTag(string? id = null, string? name = null, string? color = null) {
        this.ID = id;
        this.Name = name;
        this.Color = color;
    }

    [JsonPropertyName("id")]
    public string? ID { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("color")]
    public string? Color { get; set; }
}
