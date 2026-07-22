using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompaniesSearchAndEnrichRequest")]
public class CompaniesSearchAndEnrichRequest {
    public CompaniesSearchAndEnrichRequest(List<CompanySearchItem> companies, SearchOptions? options = null) {
        this.Companies = companies ?? throw new ArgumentNullException("companies is a required property for V3CompaniesSearchAndEnrichRequest and cannot be null");
        this.Options = options;
    }

    [JsonPropertyName("companies")]
    public List<CompanySearchItem> Companies { get; set; }
    [JsonPropertyName("options")]
    public SearchOptions? Options { get; set; }
}
