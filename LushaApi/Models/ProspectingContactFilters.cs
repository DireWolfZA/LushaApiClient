using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ProspectingContactFilters")]
public class ProspectingContactFilters {
    [JsonPropertyName("contacts")]
    public ProspectingContactFiltersContacts? Contacts { get; set; }
    [JsonPropertyName("companies")]
    public ProspectingContactFiltersCompanies? Companies { get; set; }
}
