using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3SearchAndEnrichCompanyResult")]
public class SearchAndEnrichCompanyResult {
    [JsonPropertyName("id")]
    public string? ID { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("alternativeName")]
    public string? AlternativeName { get; set; }
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }
    [JsonPropertyName("alternativeDomains")]
    public List<string>? AlternativeDomains { get; set; }
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    [JsonPropertyName("companyType")]
    public string? CompanyType { get; set; }
    [JsonPropertyName("yearFounded")]
    public decimal? YearFounded { get; set; }
    [JsonPropertyName("employeeCount")]
    public CompanyPreviewEmployeeCount? EmployeeCount { get; set; }
    [JsonPropertyName("industry")]
    public string? Industry { get; set; }
    [JsonPropertyName("subIndustry")]
    public string? SubIndustry { get; set; }
    [JsonPropertyName("specialities")]
    public List<string>? Specialities { get; set; }
    [JsonPropertyName("industryTags")]
    public List<string>? IndustryTags { get; set; }
    [JsonPropertyName("sicCodes")]
    public List<SICCode>? SICCodes { get; set; }
    [JsonPropertyName("naicsCodes")]
    public List<NAICSCode>? NAICSCodes { get; set; }
    [JsonPropertyName("location")]
    public CompanyLocation? Location { get; set; }
    [JsonPropertyName("additionalLocations")]
    public List<CompanyLocation>? AdditionalLocations { get; set; }
    [JsonPropertyName("socialLinks")]
    public CompanyPreviewSocialLinks? SocialLinks { get; set; }
    [JsonPropertyName("linkedinFollowers")]
    public decimal? LinkedInFollowers { get; set; }
    [JsonPropertyName("revenueRange")]
    public EnrichedCompanyRevenueRange? RevenueRange { get; set; }
    /// <summary>
    /// Funding payload when present
    /// </summary>
    [JsonPropertyName("funding")]
    public object? Funding { get; set; }
    /// <summary>
    /// Intent payload when present
    /// </summary>
    [JsonPropertyName("intent")]
    public object? Intent { get; set; }
    [JsonPropertyName("technologies")]
    public List<string>? Technologies { get; set; }
    [JsonPropertyName("popularityTier")]
    public decimal? PopularityTier { get; set; }
    [JsonPropertyName("logoUrl")]
    public string? LogoURL { get; set; }
    /// <summary>
    /// Breakdown of employees by department. Revealed via &#x60;reveal: [&quot;employeesByDepartment&quot;]&#x60; in Enrich Companies.
    /// </summary>
    [JsonPropertyName("employeesByDepartment")]
    public List<EnrichedCompanyEmployeesByDepartmentInner>? EmployeesByDepartment { get; set; }
    /// <summary>
    /// Breakdown of employees by country and state. Revealed via &#x60;reveal: [&quot;employeesByLocation&quot;]&#x60; in Enrich Companies.
    /// </summary>
    [JsonPropertyName("employeesByLocation")]
    public List<EnrichedCompanyEmployeesByLocationInner>? EmployeesByLocation { get; set; }
    /// <summary>
    /// Breakdown of employees by seniority level. Revealed via &#x60;reveal: [&quot;employeesBySeniority&quot;]&#x60; in Enrich Companies.
    /// </summary>
    [JsonPropertyName("employeesBySeniority")]
    public List<EnrichedCompanyEmployeesBySeniorityInner>? EmployeesBySeniority { get; set; }
    /// <summary>
    /// List of competitor companies. Revealed via &#x60;reveal: [&quot;competitors&quot;]&#x60; in Enrich Companies. Use Enrich Companies with the returned IDs to get full firmographic data on each competitor.
    /// </summary>
    [JsonPropertyName("competitors")]
    public List<EnrichedCompanyCompetitorsInner>? Competitors { get; set; }
    /// <summary>
    /// Company business model classification (e.g. B2B, B2C)
    /// </summary>
    [JsonPropertyName("businessModel")]
    public List<string>? BusinessModel { get; set; }
    /// <summary>
    /// Company phone number
    /// </summary>
    [JsonPropertyName("phone")]
    public string? Phone { get; set; }
    /// <summary>
    /// Company contact email address
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }
    /// <summary>
    /// Keywords associated with the company (normalized from specialities and description)
    /// </summary>
    [JsonPropertyName("keywords")]
    public List<string>? Keywords { get; set; }
    /// <summary>
    /// Normalized version of the specialities list
    /// </summary>
    [JsonPropertyName("specialitiesRefactored")]
    public List<string>? SpecialitiesRefactored { get; set; }
    [JsonPropertyName("error")]
    public ItemError? Error { get; set; }
    [JsonPropertyName("clientReferenceId")]
    public string? ClientReferenceID { get; set; }
}
