using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompanySignalsRequest")]
public class CompanySignalsRequest {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SignalTypesEnum {
        [JsonStringEnumMemberName("allSignals")]
        AllSignals = 1,
        [JsonStringEnumMemberName("websiteTrafficDecrease")]
        WebsiteTrafficDecrease = 2,
        [JsonStringEnumMemberName("websiteTrafficIncrease")]
        WebsiteTrafficIncrease = 3,
        [JsonStringEnumMemberName("itSpendIncrease")]
        ITSpendIncrease = 4,
        [JsonStringEnumMemberName("itSpendDecrease")]
        ITSpendDecrease = 5,
        [JsonStringEnumMemberName("surgeInHiring")]
        SurgeInHiring = 6,
        [JsonStringEnumMemberName("headcountIncrease1m")]
        HeadcountIncrease1M = 7,
        [JsonStringEnumMemberName("headcountIncrease3m")]
        HeadcountIncrease3M = 8,
        [JsonStringEnumMemberName("headcountIncrease6m")]
        HeadcountIncrease6M = 9,
        [JsonStringEnumMemberName("headcountIncrease12m")]
        HeadcountIncrease12M = 10,
        [JsonStringEnumMemberName("headcountDecrease1m")]
        HeadcountDecrease1M = 11,
        [JsonStringEnumMemberName("headcountDecrease3m")]
        HeadcountDecrease3M = 12,
        [JsonStringEnumMemberName("headcountDecrease6m")]
        HeadcountDecrease6M = 13,
        [JsonStringEnumMemberName("headcountDecrease12m")]
        HeadcountDecrease12M = 14,
        [JsonStringEnumMemberName("surgeInHiringByDepartment")]
        SurgeInHiringByDepartment = 15,
        [JsonStringEnumMemberName("surgeInHiringByLocation")]
        SurgeInHiringByLocation = 16,
        [JsonStringEnumMemberName("riskNews")]
        RiskNews = 17,
        [JsonStringEnumMemberName("commercialActivityNews")]
        CommercialActivityNews = 18,
        [JsonStringEnumMemberName("corporateStrategyNews")]
        CorporateStrategyNews = 19,
        [JsonStringEnumMemberName("financialEventsNews")]
        FinancialEventsNews = 20,
        [JsonStringEnumMemberName("peopleNews")]
        PeopleNews = 21,
        [JsonStringEnumMemberName("marketIntelligenceNews")]
        MarketIntelligenceNews = 22,
        [JsonStringEnumMemberName("productActivityNews")]
        ProductActivityNews = 23
    }

    [JsonPropertyName("ids")]
    public required List<string> IDs { get; set; }
    [JsonPropertyName("signalTypes")]
    public required List<SignalTypesEnum> SignalTypes { get; set; }
    [JsonPropertyName("startDate")]
    public DateOnly? StartDate { get; set; }
    [JsonPropertyName("maxResultsPerSignal")]
    public int? MaxResultsPerSignal { get; set; }
}
