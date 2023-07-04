using FirstCSharp.VetmanagerApiGateway.PathUri;

namespace FirstCSharp.VetmanagerApiGateway.ModelFacade
{
    public class ClientFacade : AbstactModelFacade, ModelFacadeInterface
    {
        public ClientFacade(ApiGateway apiGateway) : base(apiGateway)
        {
        }

        public static AccessibleModelPathUri GetAccessibleModel() => AccessibleModelPathUri.client;
    }
}
