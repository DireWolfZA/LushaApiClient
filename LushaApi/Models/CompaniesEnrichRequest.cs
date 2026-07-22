using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3CompaniesEnrichRequest")]
public class CompaniesEnrichRequest {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RevealEnum {
        [EnumMember(Value = "employeesByDepartment")]
        EmployeesByDepartment = 1,
        [EnumMember(Value = "employeesByLocation")]
        EmployeesByLocation = 2,
        [EnumMember(Value = "employeesBySeniority")]
        EmployeesBySeniority = 3,
        [EnumMember(Value = "competitors")]
        Competitors = 4,
        [EnumMember(Value = "intent")]
        Intent = 5
    }

    /// <param name="ids">Company IDs from search results (strings) (required).</param>
    /// <param name="reveal">
    /// Additional data fields to reveal. Each field is charged separately per result.
    /// <br />- &#x60;employeesByDepartment&#x60; — breakdown of employees by department
    /// <br />- &#x60;employeesByLocation&#x60; — breakdown of employees by country/state
    /// <br />- &#x60;employeesBySeniority&#x60; — breakdown of employees by seniority level
    /// <br />- &#x60;competitors&#x60; — list of competitor company IDs
    /// <br />- &#x60;intent&#x60; — buyer intent topics
    /// </param>
    public CompaniesEnrichRequest(List<string> ids, List<RevealEnum>? reveal = null) {
        this.IDs = ids ?? throw new ArgumentNullException("ids is a required property for V3CompaniesEnrichRequest and cannot be null");
        this.Reveal = reveal;
    }

    /// <summary>
    /// Company IDs from search results (strings)
    /// </summary>
    [JsonPropertyName("ids")]
    public List<string> IDs { get; set; }
    /// <summary>
    /// Additional data fields to reveal. Each field is charged separately per result.
    /// <br />- &#x60;employeesByDepartment&#x60; — breakdown of employees by department
    /// <br />- &#x60;employeesByLocation&#x60; — breakdown of employees by country/state
    /// <br />- &#x60;employeesBySeniority&#x60; — breakdown of employees by seniority level
    /// <br />- &#x60;competitors&#x60; — list of competitor company IDs
    /// <br />- &#x60;intent&#x60; — buyer intent topics
    /// <br />Example: [&quot;employeesByDepartment&quot;,&quot;employeesByLocation&quot;,&quot;employeesBySeniority&quot;,&quot;competitors&quot;,&quot;intent&quot;]
    /// </summary>
    [JsonPropertyName("reveal")]
    public List<RevealEnum>? Reveal { get; set; }
}
