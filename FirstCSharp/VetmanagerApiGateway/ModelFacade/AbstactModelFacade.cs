using FirstCSharp.VetmanagerApiGateway.PathUri;

namespace FirstCSharp.VetmanagerApiGateway.ModelFacade
{
    abstract public class AbstactModelFacade
    {
        protected readonly ApiGateway ApiGateway;

        public AbstactModelFacade(ApiGateway apiGateway)
        {
            ApiGateway = apiGateway;
        }
    }
}
