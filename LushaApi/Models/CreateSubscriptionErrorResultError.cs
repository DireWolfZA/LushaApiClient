using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace LushaApi.Models;

[DataContract(Name = "CreateSubscriptionErrorResult_error")]
public class CreateSubscriptionErrorResultError {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CodeEnum {
        [JsonStringEnumMemberName("VALIDATION_ERROR")]
        ValidationError = 1,
        [JsonStringEnumMemberName("DUPLICATE_SUBSCRIPTION")]
        DuplicateSubscription = 2,
        [JsonStringEnumMemberName("URL_VALIDATION_FAILED")]
        URLValidationFailed = 3,
        [JsonStringEnumMemberName("WEBHOOK_VERIFICATION_FAILED")]
        WebhookVerificationFailed = 4,
        [JsonStringEnumMemberName("FORBIDDEN")]
        Forbidden = 5,
        [JsonStringEnumMemberName("UNKNOWN_ERROR")]
        UnknownError = 6
    }

    [JsonPropertyName("code")]
    public required CodeEnum Code { get; set; }
    [JsonPropertyName("message")]
    public required string Message { get; set; }
}
