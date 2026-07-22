using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3SearchAndEnrichCompanyResult")]
public class SearchAndEnrichCompanyResult {
    /// <param name="employeesByDepartment">Breakdown of employees by department. Revealed via &#x60;reveal: [&quot;employeesByDepartment&quot;]&#x60; in Enrich Companies.</param>
    /// <param name="employeesByLocation">Breakdown of employees by country and state. Revealed via &#x60;reveal: [&quot;employeesByLocation&quot;]&#x60; in Enrich Companies.</param>
    /// <param name="employeesBySeniority">Breakdown of employees by seniority level. Revealed via &#x60;reveal: [&quot;employeesBySeniority&quot;]&#x60; in Enrich Companies.</param>
    /// <param name="competitors">List of competitor companies. Revealed via &#x60;reveal: [&quot;competitors&quot;]&#x60; in Enrich Companies. Use Enrich Companies with the returned IDs to get full firmographic data on each competitor.</param>
    /// <param name="businessModel">Company business model classification (e.g. B2B, B2C).</param>
    /// <param name="phone">Company phone number.</param>
    /// <param name="email">Company contact email address.</param>
    /// <param name="keywords">Keywords associated with the company (normalized from specialities and description).</param>
    /// <param name="specialitiesRefactored">Normalized version of the specialities list.</param>
    public SearchAndEnrichCompanyResult(string? id = null, string? name = null, string? alternativeName = null, string? domain = null, List<string>? alternativeDomains = null, string? description = null, string? companyType = null, decimal? yearFounded = null, CompanyPreviewEmployeeCount? employeeCount = null, string? industry = null, string? subIndustry = null, List<string>? specialities = null, List<string>? industryTags = null, List<SICCode>? sicCodes = null, List<NAICSCode>? naicsCodes = null, CompanyLocation? location = null, List<CompanyLocation>? additionalLocations = null, CompanyPreviewSocialLinks? socialLinks = null, decimal? linkedinFollowers = null, EnrichedCompanyRevenueRange? revenueRange = null, object? funding = null, object? intent = null, List<string>? technologies = null, decimal? popularityTier = null, string? logoURL = null, List<EnrichedCompanyEmployeesByDepartmentInner>? employeesByDepartment = null, List<EnrichedCompanyEmployeesByLocationInner>? employeesByLocation = null, List<EnrichedCompanyEmployeesBySeniorityInner>? employeesBySeniority = null, List<EnrichedCompanyCompetitorsInner>? competitors = null, List<string>? businessModel = null, string? phone = null, string? email = null, List<string>? keywords = null, List<string>? specialitiesRefactored = null, ItemError? error = null, string? clientReferenceID = null) {
        this.ID = id;
        this.Name = name;
        this.AlternativeName = alternativeName;
        this.Domain = domain;
        this.AlternativeDomains = alternativeDomains;
        this.Description = description;
        this.CompanyType = companyType;
        this.YearFounded = yearFounded;
        this.EmployeeCount = employeeCount;
        this.Industry = industry;
        this.SubIndustry = subIndustry;
        this.Specialities = specialities;
        this.IndustryTags = industryTags;
        this.SICCodes = sicCodes;
        this.NAICSCodes = naicsCodes;
        this.Location = location;
        this.AdditionalLocations = additionalLocations;
        this.SocialLinks = socialLinks;
        this.LinkedInFollowers = linkedinFollowers;
        this.RevenueRange = revenueRange;
        this.Funding = funding;
        this.Intent = intent;
        this.Technologies = technologies;
        this.PopularityTier = popularityTier;
        this.LogoURL = logoURL;
        this.EmployeesByDepartment = employeesByDepartment;
        this.EmployeesByLocation = employeesByLocation;
        this.EmployeesBySeniority = employeesBySeniority;
        this.Competitors = competitors;
        this.BusinessModel = businessModel;
        this.Phone = phone;
        this.Email = email;
        this.Keywords = keywords;
        this.SpecialitiesRefactored = specialitiesRefactored;
        this.Error = error;
        this.ClientReferenceID = clientReferenceID;
    }

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
