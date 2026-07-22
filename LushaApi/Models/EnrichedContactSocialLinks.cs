using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3EnrichedContact_socialLinks")]
public class EnrichedContactSocialLinks {
    public EnrichedContactSocialLinks(string linkedin = null, string xurl = null) {
        this.LinkedIn = linkedin;
        this.XUrl = xurl;
    }

    [JsonPropertyName("linkedin")]
    public string LinkedIn { get; set; }
    [JsonPropertyName("xUrl")]
    public string XUrl { get; set; }
}
