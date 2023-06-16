using FirstCSharp.DTO;
using System.Net.Http.Headers;
using System.Text.Json;
using static FirstCSharp.VetmanagerApiGateway;

namespace FirstCSharp
{
    internal class VetmanagerApiGateway
    {
        private readonly HttpClient httpClient;
        private readonly string domainName;
        private readonly string apiKey;
        private readonly bool isProdServer;

        public VetmanagerApiGateway(HttpClient httpClient, string domainName, string apiKey, bool isProdServer)
        {
            this.httpClient = httpClient;
            this.domainName = domainName;
            this.apiKey = apiKey;
            this.isProdServer = isProdServer;

            httpClient.BaseAddress = new Uri($"https://{domainName}.test.kube-dev.vetmanager.cloud");
            httpClient.DefaultRequestHeaders
                  .Accept
                  .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add("X-REST-API-KEY", apiKey);
        }

        public async Task<Client> GetClient(int id)
        {
            var apiResponse = await GetModelsDataFromApi<ClientData>(new PathUri(Model.client, id));
            return apiResponse.Client;
        }

        public async Task<Client[]> GetAllClients()
        {
            var apiResponse = await GetModelsDataFromApi<ClientListData>(new PathUri(Model.client));
            return apiResponse.Clients ?? Array.Empty<Client>();
        }

        public async Task<TModelData> GetModelsDataFromApi<TModelData>(PathUri pathUri) where TModelData: AbstractModelDataWithStringTotalCount
        {
            string apiResponseAsJson = await httpClient.GetStringAsync(
                    pathUri.ToString()
                );
            var apiResponse = JsonSerializer.Deserialize<ApiResponse<TModelData>>(apiResponseAsJson) ?? throw new Exception("Wrong API response");
            return apiResponse.Data;
        }

        public enum Model
        {
            client,
            pet
        }

        public class PathUri
        {
            private const string s_prefix = "/rest/api/";
            private readonly Model model;
            private readonly int id;

            public PathUri(Model model)
            {
                this.model = model;
            }

            public PathUri(Model model, int id)
            {
                this.model = model;
                this.id = id;
            }

            public override string ToString() { return s_prefix + model.ToString() + GetEndingWithIdIfPresent(); }

            private string GetEndingWithIdIfPresent() { return (id == 0) ? "" : $"/{id}"; }
        }
    }
}

