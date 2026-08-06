using System.Threading.Tasks;
using LushaApi.Models;
using LushaApi.Utils;
using RestSharp;

namespace LushaApi.Actions;

public interface IAccountActions {
    Task<AccountUsageResponse> GetUsage();
}

public class AccountActions : IAccountActions {
    private readonly RestClient client;
    public AccountActions(RestClient client) {
        this.client = client;
    }
    private const string baseURL = "v3/account";

    //https://docs.lusha.com/apis/openapi/account/getaccountusage
    public async Task<AccountUsageResponse> GetUsage() {
        var request = new RestRequest($"{baseURL}/usage", Method.Get);

        return RestResponseHandler.Handle(await client.ExecuteAsync<AccountUsageResponse>(request, Method.Get));
    }
}
