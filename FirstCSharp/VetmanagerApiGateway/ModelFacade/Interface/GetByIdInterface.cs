using FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer.Model;

namespace FirstCSharp.VetmanagerApiGateway.ModelFacade.Interface
{
    internal interface GetByIdInterface<T> where T : AbstractModel
    {
        Task<T> ById(int id);
    }
}
