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
    /// <summary>
    /// Should be <see cref="DateOnly"/>, but netstandard2.0 doesn't include it
    /// </summary>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }
}
