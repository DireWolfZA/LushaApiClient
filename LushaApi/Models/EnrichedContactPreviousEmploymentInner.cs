using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3EnrichedContact_previousEmployment_inner")]
public class EnrichedContactPreviousEmploymentInner {
    [JsonPropertyName("company")]
    public EnrichedContactPreviousEmploymentInnerCompany? Company { get; set; }
    [JsonPropertyName("jobTitle")]
    public EnrichedContactPreviousEmploymentInnerJobTitle? JobTitle { get; set; }
}
