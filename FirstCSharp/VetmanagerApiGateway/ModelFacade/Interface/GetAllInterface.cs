using FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer.Model;

namespace FirstCSharp.VetmanagerApiGateway.ModelFacade.Interface
{
    internal interface GetAllInterface<T> where T : AbstractModel
    {
        Task<T[]> All();
    }
}
