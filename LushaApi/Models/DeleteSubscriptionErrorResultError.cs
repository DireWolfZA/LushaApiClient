using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "DeleteSubscriptionErrorResult_error")]
public class DeleteSubscriptionErrorResultError {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CodeEnum {
        [JsonStringEnumMemberName("NOT_FOUND")]
        NotFound = 1,
        [JsonStringEnumMemberName("VALIDATION_ERROR")]
        ValidationError = 2,
        [JsonStringEnumMemberName("FORBIDDEN")]
        Forbidden = 3,
        [JsonStringEnumMemberName("UNKNOWN_ERROR")]
        UnknownError = 4
    }

    [JsonPropertyName("code")]
    public required CodeEnum Code { get; set; }
    [JsonPropertyName("message")]
    public required string Message { get; set; }
}
