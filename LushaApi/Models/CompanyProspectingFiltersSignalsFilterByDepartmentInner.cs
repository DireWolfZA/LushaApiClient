using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompanyProspectingFilters_signals_filterByDepartment_inner")]
public class CompanyProspectingFiltersSignalsFilterByDepartmentInner {
    [JsonPropertyName("department")]
    public required string Department { get; set; }
    [JsonPropertyName("startDate")]
    public DateOnly? StartDate { get; set; }
}
