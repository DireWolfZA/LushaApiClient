using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "regenerateAccountSecret_200_response")]
public class RegenerateAccountSecret200Response {
    /// <summary>
    /// Newly generated account webhook secret (store securely - only shown once)
    /// </summary>
    [JsonPropertyName("secret")]
    public required string Secret { get; set; }
}
