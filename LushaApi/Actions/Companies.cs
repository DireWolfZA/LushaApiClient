using System.Threading.Tasks;
using LushaApi.Models;
using LushaApi.Utils;
using RestSharp;

namespace LushaApi.Actions;

public interface ICompanyActions {
    Task<CompaniesSearchResponse> Search(CompaniesSearchRequest searchParams);
    Task<CompaniesEnrichResponse> Enrich(CompaniesEnrichRequest searchParams);
    Task<CompaniesSearchAndEnrichResponse> SearchAndEnrich(CompaniesSearchAndEnrichRequest searchParams);
}

public class CompanyActions : ICompanyActions {
    private readonly RestClient client;
    public CompanyActions(RestClient client) {
        this.client = client;
    }

    //https://docs.lusha.com/apis/openapi/search/searchcompanies
    public async Task<CompaniesSearchResponse> Search(CompaniesSearchRequest searchParams) {
        var request = new RestRequest("companies/search", Method.Post)
            .AddJsonBody(searchParams);

        return RestResponseHandler.Handle(await client.ExecuteAsync<CompaniesSearchResponse>(request, Method.Post));
    }

    //https://docs.lusha.com/apis/openapi/enrich/enrichcompanies
    public async Task<CompaniesEnrichResponse> Enrich(CompaniesEnrichRequest searchParams) {
        var request = new RestRequest("companies/enrich", Method.Post)
            .AddJsonBody(searchParams);

        return RestResponseHandler.Handle(await client.ExecuteAsync<CompaniesEnrichResponse>(request, Method.Post));
    }

    //https://docs.lusha.com/apis/openapi/search-and-enrich/searchandenrichcompanies
    public async Task<CompaniesSearchAndEnrichResponse> SearchAndEnrich(CompaniesSearchAndEnrichRequest searchParams) {
        var request = new RestRequest("companies/search-and-enrich", Method.Post)
            .AddJsonBody(searchParams);

        return RestResponseHandler.Handle(await client.ExecuteAsync<CompaniesSearchAndEnrichResponse>(request, Method.Post));
    }
}
