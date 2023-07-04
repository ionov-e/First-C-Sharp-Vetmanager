using FirstCSharp.VetmanagerApiGateway.PathUri;

namespace FirstCSharp.VetmanagerApiGateway.ModelFacade
{
    internal interface ModelFacadeInterface
    {
        //static abstract AccessibleModelPathUri GetAccessibleModel();
        static abstract AccessibleModelPathUri ModelPathUri { get; }
    }
}
