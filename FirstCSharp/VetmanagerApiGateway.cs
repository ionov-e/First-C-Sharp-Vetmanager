﻿using FirstCSharp.DTO;
using FirstCSharp.DTO.RootDataWithModel;
using FirstCSharp.DTO.RootDataWithModel.Model;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;
using static FirstCSharp.VetmanagerApiGateway;
using static FirstCSharp.VetmanagerApiGateway.PathUri;

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

        public async Task<Client[]> GetAllClients() { return await GetModels<Client, ClientListData>(Model.client); }

        public async Task<Breed[]> GetAllBreeds() { return await GetModels<Breed, BreedListData>(Model.breed); }

        public async Task<PetType[]> GetAllPetTypes() { return await GetModels<PetType, PetTypeListData>(Model.petType); }

        public async Task<Client> GetClient(int id) { return await GetModel<Client, ClientData>(Model.client, id); }

        public async Task<Pet[]> GetPetByClientId(int id)
        {
            var apiResponse = await GetModelsDataFromApi<PetListData>(new PathUri(Model.pet, new[] { new Filter("owner_id", id.ToString()) }));
            return apiResponse.GetModels();
        }

        public async Task<TModel> GetModel<TModel, TRootData>(Model model, int id)
            where TModel : ModelInterface
            where TRootData : AbstractContainerWithOneModelAndIntCount
        {
            var apiResponse = await GetModelsDataFromApi<TRootData>(new PathUri(model, id));
            return (TModel)apiResponse.GetModel();
        }

        public async Task<TModel[]> GetModels<TModel, TRootData>(Model model)
            where TModel : ModelInterface
            where TRootData : AbstractContainerWithModelsAndStringCount
        {
            var apiResponse = await GetModelsDataFromApi<TRootData>(new PathUri(model));
            var modelsFromApi = apiResponse.GetModels();
            TModel[] arrayOfModelsExplicitlyConverted = new TModel[modelsFromApi.Length];

            for (int intCounter = 0; intCounter < modelsFromApi.Length; intCounter++)
            {
                arrayOfModelsExplicitlyConverted[intCounter] = (TModel)modelsFromApi[intCounter];
            }

            return arrayOfModelsExplicitlyConverted;
        }

        public async Task<TRootModelData> GetModelsDataFromApi<TRootModelData>(PathUri pathUri) where TRootModelData : ContainerInterface
        {
            string apiResponseAsJson = await httpClient.GetStringAsync(pathUri.ToString());
            var apiResponse = JsonSerializer.Deserialize<EnitreApiResponse<TRootModelData>>(apiResponseAsJson) ?? throw new Exception("Wrong API response from Get Request");
            return apiResponse.Data;
        }

        public async Task<TRootDataWithModels> PostModelToApi<TRootDataWithModels>(PathUri pathUri, object objectForSerialization) where TRootDataWithModels : AbstractContainerWithModelAndIntCount
        {
            StringContent jsonContent = new(JsonSerializer.Serialize(objectForSerialization), Encoding.UTF8, "application/json" );
            string pathUriAsString = pathUri.ToString();
            HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(pathUriAsString, jsonContent);
            var jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
            var apiResponse = JsonSerializer.Deserialize<EnitreApiResponse<TRootDataWithModels>>(jsonResponse) ?? throw new Exception("Wrong API response from Get Request");
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
            var apiResponse = JsonSerializer.Deserialize<EnitreApiResponse<RootDataFromDelete>>(jsonResponse) ?? throw new Exception("Wrong API response from Delete Request");
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

