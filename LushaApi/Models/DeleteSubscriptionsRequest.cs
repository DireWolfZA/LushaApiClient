using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "deleteSubscriptions_request")]
public class DeleteSubscriptionsRequest {
    /// <summary>
    /// Array of subscription IDs to delete
    /// </summary>
    [JsonPropertyName("ids")]
    public required List<string> IDs { get; set; }
}
