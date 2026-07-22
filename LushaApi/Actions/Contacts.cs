using System.Threading.Tasks;
using LushaApi.Models;
using LushaApi.Utils;
using RestSharp;

namespace LushaApi.Actions;

public interface IContactActions {
    Task<ContactsSearchResponse> Search(ContactsSearchRequest searchParams);
    Task<ContactsEnrichResponse> Enrich(ContactsEnrichRequest searchParams);
    Task<ContactsSearchAndEnrichResponse> SearchAndEnrich(ContactsSearchAndEnrichRequest searchParams);
}

public class ContactActions : IContactActions {
    private readonly RestClient client;
    public ContactActions(RestClient client) {
        this.client = client;
    }

    //https://docs.lusha.com/apis/openapi/search/searchcontacts
    public async Task<ContactsSearchResponse> Search(ContactsSearchRequest searchParams) {
        var request = new RestRequest("contacts/search", Method.Post)
            .AddJsonBody(searchParams);

        return RestResponseHandler.Handle(await client.ExecuteAsync<ContactsSearchResponse>(request, Method.Post));
    }

    //https://docs.lusha.com/apis/openapi/enrich/enrichcontacts
    public async Task<ContactsEnrichResponse> Enrich(ContactsEnrichRequest searchParams) {
        var request = new RestRequest("contacts/enrich", Method.Post)
            .AddJsonBody(searchParams);

        return RestResponseHandler.Handle(await client.ExecuteAsync<ContactsEnrichResponse>(request, Method.Post));
    }

    //https://docs.lusha.com/apis/openapi/search-and-enrich/searchandenrichcontacts
    public async Task<ContactsSearchAndEnrichResponse> SearchAndEnrich(ContactsSearchAndEnrichRequest searchParams) {
        var request = new RestRequest("contacts/search-and-enrich", Method.Post)
            .AddJsonBody(searchParams);

        return RestResponseHandler.Handle(await client.ExecuteAsync<ContactsSearchAndEnrichResponse>(request, Method.Post));
    }
}
