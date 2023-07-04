using FirstCSharp.VetmanagerApiGateway.PathUri;

namespace FirstCSharp.VetmanagerApiGateway.ModelFacade
{
    abstract public class AbstactModelFacade
    {
        private readonly ApiGateway ApiGateway;

        public AbstactModelFacade(ApiGateway apiGateway)
        {
            ApiGateway = apiGateway;
        }
    }
}
