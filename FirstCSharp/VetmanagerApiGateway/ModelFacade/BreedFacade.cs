using FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer;
using FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer.Model;
using FirstCSharp.VetmanagerApiGateway.ModelFacade.Interface;
using FirstCSharp.VetmanagerApiGateway.PathUri;

namespace FirstCSharp.VetmanagerApiGateway.ModelFacade
{
    public class BreedFacade : AbstactModelFacade, ModelFacadeInterface, GetByIdInterface<Breed>, GetAllInterface<Breed>
    {
        public BreedFacade(ApiGateway apiGateway) : base(apiGateway)
        {
        }

        public static AccessibleModelPathUri ModelPathUri => AccessibleModelPathUri.breed;

        public async Task<Breed> ById(int id) => await ApiGateway.GetModel<Breed, BreedData>(ModelPathUri, id);

        public async Task<Breed[]> All() => await ApiGateway.GetModels<Breed, BreedListData>(ModelPathUri);
    }
}
