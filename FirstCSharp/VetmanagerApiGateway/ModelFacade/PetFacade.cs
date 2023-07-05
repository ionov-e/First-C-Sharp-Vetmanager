using FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer;
using FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer.Model;
using FirstCSharp.VetmanagerApiGateway.ModelFacade.Interface;
using FirstCSharp.VetmanagerApiGateway.PathUri;

namespace FirstCSharp.VetmanagerApiGateway.ModelFacade
{
    public class PetFacade : AbstactModelFacade, ModelFacadeInterface, GetByIdInterface<Pet>, GetAllInterface<Pet>
    {
        public PetFacade(ApiGateway apiGateway) : base(apiGateway)
        {
        }

        public static AccessibleModelPathUri ModelPathUri => AccessibleModelPathUri.pet;

        public async Task<Pet> ById(int id) => await ApiGateway.GetModel<Pet, PetData>(ModelPathUri, id);

        public async Task<Pet[]> All() => await ApiGateway.GetModels<Pet, PetListData>(ModelPathUri);

        public async Task<Pet[]> ByClientId(int id)
        {
            var apiResponse = await ApiGateway.GetModelsData<PetListData>(new PathUri.PathUri(AccessibleModelPathUri.pet, new[] { new Filter("owner_id", id.ToString()) }));
            return apiResponse.GetModels();
        }
    }
}
