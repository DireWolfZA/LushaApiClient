using System.Text.Json;
using LushaApi.Actions;
using RestSharp;
using RestSharp.Serializers.Json;

namespace LushaApi;

public interface ILushaApiClient {
    IContactActions Contacts { get; }
    ICompanyActions Companies { get; }
}

public class LushaApiClient : ILushaApiClient {
    private readonly RestClient client;

    public LushaApiClient([System.Diagnostics.CodeAnalysis.AllowNull] string apikey) {
        Utils.Utils.RequireStringArgument(apikey);

        client = new RestClient("https://api.lusha.com/v3/", configureSerialization: config => config.UseSystemTextJson(new JsonSerializerOptions(JsonSerializerDefaults.Web)));

        client.AddDefaultHeader("Accept", "application/json");
        client.AddDefaultHeader("api_key", apikey);
    }

    public IContactActions Contacts => new ContactActions(client);
    public ICompanyActions Companies => new CompanyActions(client);
}
