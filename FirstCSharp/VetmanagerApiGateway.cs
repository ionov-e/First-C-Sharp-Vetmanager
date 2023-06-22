using FirstCSharp.DTO;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Xml.Linq;
using static FirstCSharp.VetmanagerApiGateway;

namespace FirstCSharp
{
    public class VetmanagerApiGateway
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

        public async Task<TModelData> GetModelsDataFromApi<TModelData>(PathUri pathUri) where TModelData: ModelDataInterface
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
            private readonly int? id;
            private readonly Filter[] filters;

            public PathUri(Model model)
            {
                this.model = model;
                this.filters = Array.Empty<Filter>();
            }

            public PathUri(Model model, int id)
            {
                this.model = model;
                this.id = id;
                this.filters = Array.Empty<Filter>();
            }

            public PathUri(Model model, Filter[] filters)
            {
                this.model = model;
                this.filters = filters;
            }

            public override string ToString() { return s_prefix + model.ToString() + GetIdIfPresent() + GetFiltersIfPresent(); }

            private string GetIdIfPresent() { return (id == 0) ? "" : $"/{id}"; }

            private string GetFiltersIfPresent() {
                
                if (!filters.Any()) {
                    return "";
                }

                string result = string.Empty;

                foreach (var filter in filters)
                {
                    result += filter.ToString();

                    if (!filter.Equals(filters.Last()))
                    {
                        result += ',';
                    }
                }

                return $"?filter=[{result}]";
            }

            public class Filter
            {
                private readonly string _property;
                private readonly string _value;
                private readonly string? _operator;

                public Filter(string property, string value)
                {
                    _property = property;
                    _value = value;
                }

                public Filter(string property, string value, string @operator)
                {
                    _property = property;
                    _value = value;
                    _operator = @operator;
                }

                public override string ToString()
                {
                    return "{'property':'" + _property + "', 'value':'" + _value + "'" + GetOperatorAsString() + "}";
                }

                private string GetOperatorAsString()
                {
                    return (_operator == null)
                        ? ""
                        : ", 'operator':'" + _operator + "'";
                }
            }
            
        }
    }
}

