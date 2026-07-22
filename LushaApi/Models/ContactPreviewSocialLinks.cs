using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ContactPreview_socialLinks")]
public class ContactPreviewSocialLinks {
    public ContactPreviewSocialLinks(string? linkedin = null) {
        this.LinkedIn = linkedin;
    }

    [JsonPropertyName("linkedin")]
    public string? LinkedIn { get; set; }
}
