using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompanyProspectingFilters_signals")]
public class CompanyProspectingFiltersSignals {
    [JsonPropertyName("types")]
    public List<string>? Types { get; set; }
    /// <summary>
    /// Should be <see cref="DateOnly"/>, but netstandard2.0 doesn't include it
    /// </summary>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }
    [JsonPropertyName("filterByLocation")]
    public List<CompanyProspectingFiltersSignalsFilterByLocationInner>? FilterByLocation { get; set; }
    [JsonPropertyName("filterByDepartment")]
    public List<CompanyProspectingFiltersSignalsFilterByDepartmentInner>? FilterByDepartment { get; set; }
}
