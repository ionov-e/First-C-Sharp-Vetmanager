using FirstCSharp.VetmanagerApiGateway.PathUri;

namespace FirstCSharp.VetmanagerApiGateway.ModelFacade.Interface
{
    internal interface ModelFacadeInterface
    {
        //static abstract AccessibleModelPathUri GetAccessibleModel();
        static abstract AccessibleModelPathUri ModelPathUri { get; }
    }
}
