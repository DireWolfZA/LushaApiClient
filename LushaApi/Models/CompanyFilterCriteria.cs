using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompanyFilterCriteria")]
public class CompanyFilterCriteria {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TechnologiesConditionEnum {
        [JsonStringEnumMemberName("or")]
        Or = 1,
        [JsonStringEnumMemberName("and")]
        And = 2
    }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum IntentTopicsConditionEnum {
        [JsonStringEnumMemberName("or")]
        Or = 1,
        [JsonStringEnumMemberName("and")]
        And = 2
    }

    [JsonPropertyName("names")]
    public List<string>? Names { get; set; }
    [JsonPropertyName("domains")]
    public List<string>? Domains { get; set; }
    [JsonPropertyName("ids")]
    public List<string>? IDs { get; set; }
    [JsonPropertyName("locations")]
    public List<Location>? Locations { get; set; }
    [JsonPropertyName("sizes")]
    public List<Range>? Sizes { get; set; }
    [JsonPropertyName("revenues")]
    public List<Range>? Revenues { get; set; }
    [JsonPropertyName("technologies")]
    public List<string>? Technologies { get; set; }
    [JsonPropertyName("technologiesCondition")]
    public TechnologiesConditionEnum? TechnologiesCondition { get; set; }
    [JsonPropertyName("industriesLabels")]
    public List<string>? IndustriesLabels { get; set; }
    [JsonPropertyName("mainIndustriesIds")]
    public List<int>? MainIndustriesIDs { get; set; }
    [JsonPropertyName("subIndustriesIds")]
    public List<int>? SubIndustriesIDs { get; set; }
    [JsonPropertyName("intentTopics")]
    public List<string>? IntentTopics { get; set; }
    [JsonPropertyName("intentTopicsCondition")]
    public IntentTopicsConditionEnum? IntentTopicsCondition { get; set; }
    [JsonPropertyName("topicCountThreshold")]
    public List<Range>? TopicCountThreshold { get; set; }
    [JsonPropertyName("sicCodes")]
    public List<string>? SICCodes { get; set; }
    [JsonPropertyName("naicsCodes")]
    public List<string>? NAICSCodes { get; set; }
    [JsonPropertyName("funding")]
    public CompanyFilterCriteriaFunding? Funding { get; set; }
}
