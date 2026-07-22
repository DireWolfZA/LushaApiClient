using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "V3ContactPreview_jobTitle")]
public class ContactPreviewJobTitle {
    public ContactPreviewJobTitle(string? title = null, List<string>? departments = null, string? seniority = null) {
        this.Title = title;
        this.Departments = departments;
        this.Seniority = seniority;
    }

    [JsonPropertyName("title")]
    public string? Title { get; set; }
    [JsonPropertyName("departments")]
    public List<string>? Departments { get; set; }
    [JsonPropertyName("seniority")]
    public string? Seniority { get; set; }
}
