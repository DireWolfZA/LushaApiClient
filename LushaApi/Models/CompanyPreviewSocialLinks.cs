using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompanyPreview_socialLinks")]
public class CompanyPreviewSocialLinks {
    public CompanyPreviewSocialLinks(string? linkedin = null) {
        this.LinkedIn = linkedin;
    }

    [JsonPropertyName("linkedin")]
    public string? LinkedIn { get; set; }
}
