namespace FirstCSharp.VetmanagerApiGateway
{
    public class ApiTokenCredentials
    {
        public const string DefaultApiApplicationName = "DefaultAppName";

        public string fullUrl;
        public string token;
        public string appName;

        public ApiTokenCredentials(string fullUrl, string token, string appName)
        {
            this.fullUrl = fullUrl;
            this.token = token;
            this.appName = appName;
        }

        public ApiTokenCredentials(string fullUrl, string token) : this(fullUrl, token, DefaultApiApplicationName) { }
    }
}
