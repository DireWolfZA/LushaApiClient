using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "getAccountSecret_200_response")]
public class GetAccountSecret200Response {
    /// <summary>
    /// Current account webhook secret
    /// </summary>
    [JsonPropertyName("secret")]
    public required string Secret { get; set; }
}
