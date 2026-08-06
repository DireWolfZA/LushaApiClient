using System.Threading.Tasks;
using LushaApi.Models;
using LushaApi.Utils;
using RestSharp;

namespace LushaApi.Actions;

public interface IWebhookActions {
    /// <summary>Create subscriptions (bulk supported)</summary>
    Task<CreateSubscriptionResponse> CreateSubscription(CreateSubscriptionRequest requestParams);
    /// <summary>List all subscriptions</summary>
    Task<SubscriptionListResponse> ListSubscriptions(int limit = 10, int offset = 0);
    /// <summary>Get subscription by ID</summary>
    Task<SubscriptionWithoutSecret> GetSubscription(string id);
    /// <summary>Update subscription</summary>
    Task<SubscriptionResponse> UpdateSubscription(string id, UpdateSubscriptionRequest requestParams);
    /// <summary>Test subscription delivery</summary>
    Task<TestSubscriptionResponse> TestSubscription(string id, TestSubscriptionResponse.ModeEnum? mode = TestSubscriptionResponse.ModeEnum.Full);
    /// <summary>Delete subscriptions (bulk supported)</summary>
    Task<DeleteSubscriptionResponse> DeleteSubscription(DeleteSubscriptionsRequest requestParams);
    /// <summary>Get webhook delivery logs</summary>
    Task<AuditLogsResponse> GetWebhookDeliveryLogs(string? subscriptionID = null, AuditLogEntry.StatusEnum? status = null, int limit = 50, int offset = 0);
    /// <summary>Get delivery statistics</summary>
    Task<AuditLogStatsResponse> GetWebhookDeliveryStatistics(string? subscriptionID = null);
    /// <summary>Get account webhook secret</summary>
    Task<GetAccountSecret200Response> GetAccountWebhookSecret();
    /// <summary>Regenerate account secret</summary>
    Task<RegenerateAccountSecret200Response> RegenerateAccountSecret();
    /// <summary>Subscribe to contact opt-out notifications</summary>
    Task<OptOutSubscriptionResponse> SubscribeToContactOptOutNotifications(CreateOptOutSubscriptionRequest requestParams);
}

public class WebhookActions : IWebhookActions {
    private readonly RestClient client;
    public WebhookActions(RestClient client) {
        this.client = client;
    }
    private const string baseURL = "api";

    //https://docs.lusha.com/apis/openapi/webhooks/createsubscription
    public async Task<CreateSubscriptionResponse> CreateSubscription(CreateSubscriptionRequest requestParams) {
        var request = new RestRequest($"{baseURL}/subscriptions", Method.Post)
            .AddJsonBody(requestParams);

        return RestResponseHandler.Handle(await client.ExecuteAsync<CreateSubscriptionResponse>(request, Method.Post));
    }

    //https://docs.lusha.com/apis/openapi/webhooks/listsubscriptions
    public async Task<SubscriptionListResponse> ListSubscriptions(int limit = 10, int offset = 0) {
        var request = new RestRequest($"{baseURL}/subscriptions", Method.Get)
            .AddParameter("limit", limit)
            .AddParameter("offset", offset);

        return RestResponseHandler.Handle(await client.ExecuteAsync<SubscriptionListResponse>(request, Method.Get));
    }

    //https://docs.lusha.com/apis/openapi/webhooks/getsubscriptionbyid
    public async Task<SubscriptionWithoutSecret> GetSubscription(string id) {
        Utils.Utils.RequireStringArgument(id);
        var request = new RestRequest($"{baseURL}/subscriptions/" + id, Method.Get);

        return RestResponseHandler.Handle(await client.ExecuteAsync<SubscriptionWithoutSecret>(request, Method.Get));
    }

    //https://docs.lusha.com/apis/openapi/webhooks/updatesubscription
    public async Task<SubscriptionResponse> UpdateSubscription(string id, UpdateSubscriptionRequest requestParams) {
        Utils.Utils.RequireStringArgument(id);
        var request = new RestRequest($"{baseURL}/subscriptions/" + id, Method.Patch)
            .AddJsonBody(requestParams);

        return RestResponseHandler.Handle(await client.ExecuteAsync<SubscriptionResponse>(request, Method.Patch));
    }

    //https://docs.lusha.com/apis/openapi/webhooks/testsubscription
    public async Task<TestSubscriptionResponse> TestSubscription(string id, TestSubscriptionResponse.ModeEnum? mode = null) {
        Utils.Utils.RequireStringArgument(id);
        var request = new RestRequest($"{baseURL}/subscriptions/{id}/test", Method.Post)
            .AddParameter("mode", Utils.Utils.EncodeEnumParameter(mode));

        return RestResponseHandler.Handle(await client.ExecuteAsync<TestSubscriptionResponse>(request, Method.Post));
    }

    //https://docs.lusha.com/apis/openapi/webhooks/deletesubscriptions
    public async Task<DeleteSubscriptionResponse> DeleteSubscription(DeleteSubscriptionsRequest requestParams) {
        var request = new RestRequest($"{baseURL}/subscriptions/delete", Method.Post)
            .AddJsonBody(requestParams);

        return RestResponseHandler.Handle(await client.ExecuteAsync<DeleteSubscriptionResponse>(request, Method.Post));
    }

    //https://docs.lusha.com/apis/openapi/webhooks/getauditlogs
    public async Task<AuditLogsResponse> GetWebhookDeliveryLogs(string? subscriptionID = null, AuditLogEntry.StatusEnum? status = null, int limit = 50, int offset = 0) {
        var request = new RestRequest($"{baseURL}/audit-logs", Method.Get)
            .AddParameter("subscriptionId", subscriptionID)
            .AddParameter("status", Utils.Utils.EncodeEnumParameter(status))
            .AddParameter("limit", limit)
            .AddParameter("offset", offset);

        return RestResponseHandler.Handle(await client.ExecuteAsync<AuditLogsResponse>(request, Method.Get));
    }

    //https://docs.lusha.com/apis/openapi/webhooks/getauditlogstats
    public async Task<AuditLogStatsResponse> GetWebhookDeliveryStatistics(string? subscriptionID = null) {
        var request = new RestRequest($"{baseURL}/audit-logs/stats", Method.Get)
            .AddParameter("subscriptionId", subscriptionID);

        return RestResponseHandler.Handle(await client.ExecuteAsync<AuditLogStatsResponse>(request, Method.Get));
    }

    //https://docs.lusha.com/apis/openapi/webhooks/getaccountsecret
    public async Task<GetAccountSecret200Response> GetAccountWebhookSecret() {
        var request = new RestRequest($"{baseURL}/account/secret", Method.Get);

        return RestResponseHandler.Handle(await client.ExecuteAsync<GetAccountSecret200Response>(request, Method.Get));
    }

    //https://docs.lusha.com/apis/openapi/webhooks/regenerateaccountsecret
    public async Task<RegenerateAccountSecret200Response> RegenerateAccountSecret() {
        var request = new RestRequest($"{baseURL}/account/secret/regenerate", Method.Post);

        return RestResponseHandler.Handle(await client.ExecuteAsync<RegenerateAccountSecret200Response>(request, Method.Post));
    }

    //https://docs.lusha.com/apis/openapi/webhooks/createoptoutsubscription
    public async Task<OptOutSubscriptionResponse> SubscribeToContactOptOutNotifications(CreateOptOutSubscriptionRequest requestParams) {
        var request = new RestRequest($"{baseURL}/subscriptions/opt-out", Method.Post)
            .AddJsonBody(requestParams);

        return RestResponseHandler.Handle(await client.ExecuteAsync<OptOutSubscriptionResponse>(request, Method.Post));
    }
}
