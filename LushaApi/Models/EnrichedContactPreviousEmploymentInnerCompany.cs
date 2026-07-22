using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3EnrichedContact_previousEmployment_inner_company")]
public class EnrichedContactPreviousEmploymentInnerCompany {
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }
}
