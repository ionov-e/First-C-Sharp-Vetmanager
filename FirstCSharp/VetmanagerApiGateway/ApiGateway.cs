using FirstCSharp.VetmanagerApiGateway.DTO;
using FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer;
using FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer.Model;
using FirstCSharp.VetmanagerApiGateway.PathUri;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace FirstCSharp.VetmanagerApiGateway
{
    public class ApiGateway
    {
        private readonly HttpClient httpClient;
        public readonly string fullUrl;

        /// <summary>
        /// First way authorizing API requests
        /// </summary>
        /// <param name="httpClient">Default new HttpClient is expected</param>
        /// <param name="fullUrl">Example: https://three.test.kube-dev.vetmanager.cloud</param>
        /// <param name="apiKey">You can get it from clinic's Rest API settings from admin panel</param>
        public ApiGateway(HttpClient httpClient, string fullUrl, string apiKey)
        {
            this.fullUrl = fullUrl;
            this.httpClient = httpClient;
            httpClient.BaseAddress = new Uri(fullUrl);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add("X-REST-API-KEY", apiKey);
        }

        /// <summary>
        /// Second way authorizing API requests
        /// </summary>
        /// <param name="httpClient">Default new HttpClient is expected</param>
        /// <param name="fullUrl">Example: https://three.test.kube-dev.vetmanager.cloud</param>
        /// <param name="applicationName">Same name that was used while getting Token<see cref="GetApiTokenCredentials"/></param>
        /// <param name="token">You can get Token here: <see cref="GetApiTokenCredentials"/></param>
        public ApiGateway(HttpClient httpClient, string fullUrl, string applicationName, string token)
        {
            this.httpClient = httpClient;
            this.fullUrl = fullUrl;
            httpClient.BaseAddress = new Uri(fullUrl);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add("X-APP-NAME", applicationName);
            httpClient.DefaultRequestHeaders.Add("X-USER-TOKEN", token);
        }

        public ApiGateway(HttpClient httpClient, ApiTokenCredentials apiToken) : this(httpClient, apiToken.fullUrl, apiToken.appName, apiToken.token) { }

        public static async Task<ApiGateway> ApiGatewayFromLoginAndPassword(HttpClient httpClient, string fullUrl, string login, string password, string appName)
        {
            ApiTokenCredentials credentials = await GetApiTokenCredentials(new HttpClient(), fullUrl, login, password, appName);
            return new ApiGateway(httpClient, credentials);
        }

        public static async Task<ApiTokenCredentials> GetApiTokenCredentials(HttpClient httpClient, string fullUrl, string login, string password, string appName)
        {
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

        public async Task<Client[]> GetAllClients() { return await GetModels<Client, ClientListData>(AccessibleModel.client); }

        public async Task<Breed[]> GetAllBreeds() { return await GetModels<Breed, BreedListData>(AccessibleModel.breed); }

        public async Task<PetType[]> GetAllPetTypes() { return await GetModels<PetType, PetTypeListData>(AccessibleModel.petType); }

        public async Task<Client> GetClient(int id) { return await GetModel<Client, ClientData>(AccessibleModel.client, id); }

        public async Task<Pet[]> GetPetByClientId(int id)
        {
            var apiResponse = await GetModelsData<PetListData>(new PathUri.PathUri(AccessibleModel.pet, new[] { new Filter("owner_id", id.ToString()) }));
            return apiResponse.GetModels();
        }

        private async Task<TModel> GetModel<TModel, TRootData>(AccessibleModel model, int id)
            where TModel : AbstractModel
            where TRootData : AbstractContainerWithOneModelAndIntCount
        {
            var apiResponse = await GetModelsData<TRootData>(new PathUri.PathUri(model, id));
            return (TModel)apiResponse.GetModel();
        }

        private async Task<TModel[]> GetModels<TModel, TRootData>(AccessibleModel model)
            where TModel : AbstractModel
            where TRootData : AbstractContainerWithModelsAndStringCount
        {
            var apiResponse = await GetModelsData<TRootData>(new PathUri.PathUri(model));
            var modelsFromApi = apiResponse.GetModels();
            TModel[] arrayOfModelsExplicitlyConverted = new TModel[modelsFromApi.Length];

            for (int intCounter = 0; intCounter < modelsFromApi.Length; intCounter++)
            {
                arrayOfModelsExplicitlyConverted[intCounter] = (TModel)modelsFromApi[intCounter];
            }

            return arrayOfModelsExplicitlyConverted;
        }

        private async Task<TRootModelData> GetModelsData<TRootModelData>(PathUri.PathUri pathUri) where TRootModelData : ModelContainerInterface
        {
            string apiResponseAsJson = await httpClient.GetStringAsync(pathUri.ToString());
            var apiResponse = JsonSerializer.Deserialize<ApiResponseWithModelContainer<TRootModelData>>(apiResponseAsJson) ?? throw new Exception("Wrong API response from Get Request");
            return apiResponse.Data;
        }

        public async Task<TRootDataWithModels> CreateModel<TRootDataWithModels>(PathUri.PathUri pathUri, object objectForSerialization) where TRootDataWithModels : AbstractContainerWithOneModelAndIntCount
        {
            StringContent jsonContent = new(JsonSerializer.Serialize(objectForSerialization), Encoding.UTF8, "application/json");
            string pathUriAsString = pathUri.ToString();
            HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(pathUriAsString, jsonContent);
            var jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
            var apiResponse = JsonSerializer.Deserialize<ApiResponseWithModelContainer<TRootDataWithModels>>(jsonResponse) ?? throw new Exception("Wrong API response from Post Request");
            return apiResponse.Data;
        }

        public async Task<TContainerWithOneModelAndIntCount> UpdateModel<TContainerWithOneModelAndIntCount>(PathUri.PathUri pathUri, object objectForSerialization) where TContainerWithOneModelAndIntCount : AbstractContainerWithOneModelAndIntCount
        {
            StringContent jsonContent = new(JsonSerializer.Serialize(objectForSerialization), Encoding.UTF8, "application/json");
            string pathUriAsString = pathUri.ToString();
            HttpResponseMessage httpResponseMessage = await httpClient.PutAsync(pathUriAsString, jsonContent);
            var jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
            var apiResponse = JsonSerializer.Deserialize<ApiResponseWithModelContainer<TContainerWithOneModelAndIntCount>>(jsonResponse) ?? throw new Exception("Wrong API response from Put Request");
            return apiResponse.Data;
        }

        /// <summary>
        /// Returns deleted ID on success or throws on fail
        /// </summary>
        /// <param name="pathUri"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<int> DeleteModelFromApi(PathUri.PathUri pathUri)
        {
            string pathUriAsString = pathUri.ToString();
            HttpResponseMessage httpResponseMessage = await httpClient.DeleteAsync(pathUriAsString);
            var jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
            var apiResponse = JsonSerializer.Deserialize<ApiResponseWithModelContainer<IdOnly>>(jsonResponse) ?? throw new Exception("Wrong API response from Delete Request");
            return apiResponse.Data.Id;
        }
    }
}

