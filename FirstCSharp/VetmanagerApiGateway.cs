using FirstCSharp.DTO;
using FirstCSharp.DTO.RootDataWithModel;
using FirstCSharp.DTO.RootDataWithModel.Model;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using static FirstCSharp.VetmanagerApiGateway.PathUri;

namespace FirstCSharp
{
    public class VetmanagerApiGateway
    {
        private readonly HttpClient httpClient;
        public readonly string fullUrl;

        public VetmanagerApiGateway(HttpClient httpClient, string fullUrl, string apiKey)
        {
            this.fullUrl = fullUrl;
            this.httpClient = httpClient;
            httpClient.BaseAddress = new Uri(fullUrl);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add("X-REST-API-KEY", apiKey);
        }

        public VetmanagerApiGateway(HttpClient httpClient, string fullUrl, string applicationName, string token)
        {
            this.httpClient = httpClient;
            this.fullUrl = fullUrl;
            httpClient.BaseAddress = new Uri(fullUrl);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add("X-APP-NAME", applicationName);
            httpClient.DefaultRequestHeaders.Add("X-USER-TOKEN", token);
        }

        public VetmanagerApiGateway(HttpClient httpClient, ApiTokenCredentials apiToken) : this(httpClient, apiToken.fullUrl, apiToken.appName, apiToken.token) { }

        public static async Task<ApiTokenCredentials> GetApiTokenCredentials(string fullUrl, string login, string password, string appName)
        {
            var httpClient = new HttpClient();

            MultipartFormDataContent contentToSend = new()
            {
                { new StringContent(login), "login" },
                { new StringContent(password), "password" },
                { new StringContent(appName), "app_name" }
            };

            HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(fullUrl + "/token_auth.php", contentToSend);
            var jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
            var apiResponse = JsonSerializer.Deserialize<ApiResponseWithToken>(jsonResponse) ?? throw new Exception("Wrong API response while getting API token");
            return new ApiTokenCredentials(fullUrl, apiResponse.Data.Token);
        }

        public async Task<Client[]> GetAllClients() { return await GetModels<Client, ClientListData>(Model.client); }

        public async Task<Breed[]> GetAllBreeds() { return await GetModels<Breed, BreedListData>(Model.breed); }

        public async Task<PetType[]> GetAllPetTypes() { return await GetModels<PetType, PetTypeListData>(Model.petType); }

        public async Task<Client> GetClient(int id) { return await GetModel<Client, ClientData>(Model.client, id); }

        public async Task<Pet[]> GetPetByClientId(int id)
        {
            var apiResponse = await GetModelsData<PetListData>(new PathUri(Model.pet, new[] { new Filter("owner_id", id.ToString()) }));
            return apiResponse.GetModels();
        }

        private async Task<TModel> GetModel<TModel, TRootData>(Model model, int id)
            where TModel : AbstractModel
            where TRootData : AbstractContainerWithOneModelAndIntCount
        {
            var apiResponse = await GetModelsData<TRootData>(new PathUri(model, id));
            return (TModel)apiResponse.GetModel();
        }

        private async Task<TModel[]> GetModels<TModel, TRootData>(Model model)
            where TModel : AbstractModel
            where TRootData : AbstractContainerWithModelsAndStringCount
        {
            var apiResponse = await GetModelsData<TRootData>(new PathUri(model));
            var modelsFromApi = apiResponse.GetModels();
            TModel[] arrayOfModelsExplicitlyConverted = new TModel[modelsFromApi.Length];

            for (int intCounter = 0; intCounter < modelsFromApi.Length; intCounter++)
            {
                arrayOfModelsExplicitlyConverted[intCounter] = (TModel)modelsFromApi[intCounter];
            }

            return arrayOfModelsExplicitlyConverted;
        }

        private async Task<TRootModelData> GetModelsData<TRootModelData>(PathUri pathUri) where TRootModelData : ContainerInterface
        {
            string apiResponseAsJson = await httpClient.GetStringAsync(pathUri.ToString());
            var apiResponse = JsonSerializer.Deserialize<ApiResponseWithModels<TRootModelData>>(apiResponseAsJson) ?? throw new Exception("Wrong API response from Get Request");
            return apiResponse.Data;
        }

        public async Task<TRootDataWithModels> CreateModel<TRootDataWithModels>(PathUri pathUri, object objectForSerialization) where TRootDataWithModels : AbstractContainerWithModelAndIntCount
        {
            StringContent jsonContent = new(JsonSerializer.Serialize(objectForSerialization), Encoding.UTF8, "application/json");
            string pathUriAsString = pathUri.ToString();
            HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(pathUriAsString, jsonContent);
            var jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
            var apiResponse = JsonSerializer.Deserialize<ApiResponseWithModels<TRootDataWithModels>>(jsonResponse) ?? throw new Exception("Wrong API response from Post Request");
            return apiResponse.Data;
        }

        public async Task<TRootDataWithModel> UpdateModel<TRootDataWithModel>(PathUri pathUri, object objectForSerialization) where TRootDataWithModel : AbstractContainerWithOneModelAndIntCount
        {
            StringContent jsonContent = new(JsonSerializer.Serialize(objectForSerialization), Encoding.UTF8, "application/json");
            string pathUriAsString = pathUri.ToString();
            HttpResponseMessage httpResponseMessage = await httpClient.PutAsync(pathUriAsString, jsonContent);
            var jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
            var apiResponse = JsonSerializer.Deserialize<ApiResponseWithModels<TRootDataWithModel>>(jsonResponse) ?? throw new Exception("Wrong API response from Put Request");
            return apiResponse.Data;
        }

        /// <summary>
        /// Returns deleted ID on success or throws on fail
        /// </summary>
        /// <param name="pathUri"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<int> DeleteModelFromApi(PathUri pathUri)
        {
            string pathUriAsString = pathUri.ToString();
            HttpResponseMessage httpResponseMessage = await httpClient.DeleteAsync(pathUriAsString);
            var jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
            var apiResponse = JsonSerializer.Deserialize<ApiResponseWithModels<RootDataFromDelete>>(jsonResponse) ?? throw new Exception("Wrong API response from Delete Request");
            return apiResponse.Data.Id;
        }

        public enum Model
        {
            breed,
            client,
            pet,
            petType
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

            private string GetIdIfPresent() { return (id == null) ? "" : $"/{id}"; }

            private string GetFiltersIfPresent()
            {

                if (!filters.Any())
                {
                    return "";
                }

                string filtersAsString = string.Empty;

                foreach (var filter in filters)
                {
                    filtersAsString += filter.ToString();

                    if (!filter.Equals(filters.Last()))
                    {
                        filtersAsString += ',';
                    }
                }

                return $"?filter=[{filtersAsString}]";
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

