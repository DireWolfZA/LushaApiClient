using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3EnrichedContact_previousEmployment_inner_company")]
public class EnrichedContactPreviousEmploymentInnerCompany {
    public EnrichedContactPreviousEmploymentInnerCompany(string? name = null, string? domain = null) {
        this.Name = name;
        this.Domain = domain;
    }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }
}
