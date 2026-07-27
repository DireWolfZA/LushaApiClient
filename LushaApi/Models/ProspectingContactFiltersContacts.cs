using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ProspectingContactFilters_contacts")]
public class ProspectingContactFiltersContacts {
    [JsonPropertyName("include")]
    public ContactFilterCriteria? Include { get; set; }
    [JsonPropertyName("exclude")]
    public ContactFilterCriteria? Exclude { get; set; }
}
