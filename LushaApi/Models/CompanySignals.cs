using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompanySignalsDto")]
public class CompanySignals {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypesEnum {
        [EnumMember(Value = "allSignals")]
        AllSignals = 1,
        [EnumMember(Value = "websiteTrafficDecrease")]
        WebsiteTrafficDecrease = 2,
        [EnumMember(Value = "websiteTrafficIncrease")]
        WebsiteTrafficIncrease = 3,
        [EnumMember(Value = "itSpendIncrease")]
        ITSpendIncrease = 4,
        [EnumMember(Value = "itSpendDecrease")]
        ITSpendDecrease = 5,
        [EnumMember(Value = "surgeInHiring")]
        SurgeInHiring = 6,
        [EnumMember(Value = "headcountIncrease1m")]
        HeadcountIncrease1M = 7,
        [EnumMember(Value = "headcountIncrease3m")]
        HeadcountIncrease3M = 8,
        [EnumMember(Value = "headcountIncrease6m")]
        HeadcountIncrease6M = 9,
        [EnumMember(Value = "headcountIncrease12m")]
        HeadcountIncrease12M = 10,
        [EnumMember(Value = "headcountDecrease1m")]
        HeadcountDecrease1M = 11,
        [EnumMember(Value = "headcountDecrease3m")]
        HeadcountDecrease3M = 12,
        [EnumMember(Value = "headcountDecrease6m")]
        HeadcountDecrease6M = 13,
        [EnumMember(Value = "headcountDecrease12m")]
        HeadcountDecrease12M = 14,
        [EnumMember(Value = "surgeInHiringByDepartment")]
        SurgeInHiringByDepartment = 15,
        [EnumMember(Value = "surgeInHiringByLocation")]
        SurgeInHiringByLocation = 16,
        [EnumMember(Value = "riskNews")]
        RiskNews = 17,
        [EnumMember(Value = "commercialActivityNews")]
        CommercialActivityNews = 18,
        [EnumMember(Value = "corporateStrategyNews")]
        CorporateStrategyNews = 19,
        [EnumMember(Value = "financialEventsNews")]
        FinancialEventsNews = 20,
        [EnumMember(Value = "peopleNews")]
        PeopleNews = 21,
        [EnumMember(Value = "marketIntelligenceNews")]
        MarketIntelligenceNews = 22,
        [EnumMember(Value = "productActivityNews")]
        ProductActivityNews = 23
    }

    public CompanySignals(List<TypesEnum> types, DateTimeOffset? startDate = null, int? maxResultsPerSignal = null) {
        this.Types = types ?? throw new ArgumentNullException("types is a required property for V3CompanySignalsDto and cannot be null");
        this.StartDate = startDate;
        this.MaxResultsPerSignal = maxResultsPerSignal;
    }

    [JsonPropertyName("types")]
    public List<TypesEnum> Types { get; set; }
    /// <summary>
    /// Should be <see cref="DateOnly"/>, but netstandard2.0 doesn't include it
    /// </summary>
    [JsonPropertyName("startDate")]
    public DateTimeOffset? StartDate { get; set; }
    [JsonPropertyName("maxResultsPerSignal")]
    public int? MaxResultsPerSignal { get; set; }
}
