using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompanyProspectingFilters_signals_filterByLocation_inner")]
public class CompanyProspectingFiltersSignalsFilterByLocationInner {
    [JsonPropertyName("country")]
    public string? Country { get; set; }
    [JsonPropertyName("state")]
    public string? State { get; set; }
    [JsonPropertyName("startDate")]
    public DateOnly? StartDate { get; set; }
}
