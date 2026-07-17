using System.Text.Json;
using RestSharp;
using RestSharp.Serializers.Json;

namespace LushaApi {

    public interface ILushaApiClient {
    }

    public class LushaApiClient : ILushaApiClient {
        private readonly RestClient client;

        public LushaApiClient(string apikey) {
            Utils.Utils.RequireStringArgument(apikey, nameof(apikey));

            client = new RestClient("https://api.lusha.com/v3/", configureSerialization: config => config.UseSystemTextJson(new JsonSerializerOptions(JsonSerializerDefaults.Web)));

            client.AddDefaultHeader("Accept", "application/json");
            client.AddDefaultHeader("api_key", apikey);
        }
    }
}
