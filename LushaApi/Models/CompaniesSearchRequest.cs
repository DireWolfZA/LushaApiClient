using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompaniesSearchRequest")]
public class CompaniesSearchRequest {
    public CompaniesSearchRequest(List<CompanySearchItem> companies, SearchOptions? options = null, CompanySignals? signals = null) {
        this.Companies = companies ?? throw new ArgumentNullException("companies is a required property for V3CompaniesSearchRequest and cannot be null");
        this.Options = options;
        this.Signals = signals;
    }

    [JsonPropertyName("companies")]
    public List<CompanySearchItem> Companies { get; set; }
    [JsonPropertyName("options")]
    public SearchOptions? Options { get; set; }
    [JsonPropertyName("signals")]
    public CompanySignals? Signals { get; set; }
}
