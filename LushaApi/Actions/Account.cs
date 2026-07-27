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

    //https://docs.lusha.com/apis/openapi/account/getaccountusage
    public async Task<AccountUsageResponse> GetUsage() {
        var request = new RestRequest("account/usage", Method.Get);

        return RestResponseHandler.Handle(await client.ExecuteAsync<AccountUsageResponse>(request, Method.Get));
    }
}
