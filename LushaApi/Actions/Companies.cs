using System.Threading.Tasks;
using LushaApi.Models;
using LushaApi.Utils;
using RestSharp;

namespace LushaApi.Actions;

public interface ICompanyActions {
    Task<CompaniesSearchResponse> Search(CompaniesSearchRequest searchParams);
    Task<CompaniesEnrichResponse> Enrich(CompaniesEnrichRequest searchParams);
    Task<CompaniesSearchAndEnrichResponse> SearchAndEnrich(CompaniesSearchAndEnrichRequest searchParams);
    Task<ProspectingCompaniesResponse> Prospect(ProspectingCompaniesRequest searchParams);
    Task<CompanyLookalikesResponse> Lookalikes(CompanyLookalikesRequest searchParams);
    Task<CompanySignalsResponse> Signals(CompanySignalsRequest searchParams);
}

public class CompanyActions : ICompanyActions {
    private readonly RestClient client;
    public CompanyActions(RestClient client) {
        this.client = client;
    }
    private const string baseURL = "v3/companies";

    //https://docs.lusha.com/apis/openapi/search/searchcompanies
    public async Task<CompaniesSearchResponse> Search(CompaniesSearchRequest searchParams) {
        var request = new RestRequest($"{baseURL}/search", Method.Post)
            .AddJsonBody(searchParams);

        return RestResponseHandler.Handle(await client.ExecuteAsync<CompaniesSearchResponse>(request, Method.Post));
    }

    //https://docs.lusha.com/apis/openapi/enrich/enrichcompanies
    public async Task<CompaniesEnrichResponse> Enrich(CompaniesEnrichRequest searchParams) {
        var request = new RestRequest($"{baseURL}/enrich", Method.Post)
            .AddJsonBody(searchParams);

        return RestResponseHandler.Handle(await client.ExecuteAsync<CompaniesEnrichResponse>(request, Method.Post));
    }

    //https://docs.lusha.com/apis/openapi/search-and-enrich/searchandenrichcompanies
    public async Task<CompaniesSearchAndEnrichResponse> SearchAndEnrich(CompaniesSearchAndEnrichRequest searchParams) {
        var request = new RestRequest($"{baseURL}/search-and-enrich", Method.Post)
            .AddJsonBody(searchParams);

        return RestResponseHandler.Handle(await client.ExecuteAsync<CompaniesSearchAndEnrichResponse>(request, Method.Post));
    }

    //https://docs.lusha.com/apis/openapi/prospecting/prospectingcompanies
    public async Task<ProspectingCompaniesResponse> Prospect(ProspectingCompaniesRequest searchParams) {
        var request = new RestRequest($"{baseURL}/prospecting", Method.Post)
            .AddJsonBody(searchParams);

        return RestResponseHandler.Handle(await client.ExecuteAsync<ProspectingCompaniesResponse>(request, Method.Post));
    }

    //https://docs.lusha.com/apis/openapi/lookalikes/getcompanylookalikes
    public async Task<CompanyLookalikesResponse> Lookalikes(CompanyLookalikesRequest searchParams) {
        var request = new RestRequest($"{baseURL}/lookalike", Method.Post)
            .AddJsonBody(searchParams);

        return RestResponseHandler.Handle(await client.ExecuteAsync<CompanyLookalikesResponse>(request, Method.Post));
    }

    //https://docs.lusha.com/apis/openapi/signals/getcompanysignals
    public async Task<CompanySignalsResponse> Signals(CompanySignalsRequest searchParams) {
        var request = new RestRequest($"{baseURL}/signals", Method.Post)
            .AddJsonBody(searchParams);

        return RestResponseHandler.Handle(await client.ExecuteAsync<CompanySignalsResponse>(request, Method.Post));
    }
}
