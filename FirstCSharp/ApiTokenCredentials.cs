using System.Text;
using System.Xml;

namespace FirstCSharp
{
    public class ApiTokenCredentials
    {
        public const string DefaultApiApplicationName = "TestApplication";

        private const string FileName = "last_settings.xml";
        private const string KeyRootTag = "connection";
        private const string KeyFullUrl = "fullUrl";
        private const string KeyToken = "token";
        private const string KeyAppName = "appName";

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

        public static ApiTokenCredentials? FromSaved()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FileName);

            return new ApiTokenCredentials(
                GetValueByKey(doc, KeyFullUrl),
                GetValueByKey(doc, KeyToken),
                GetValueByKey(doc, KeyAppName)
                );
        }

        private static string GetValueByKey(XmlDocument doc, string key)
        {
            XmlNode fullUrlNode = doc.DocumentElement?.SelectSingleNode($"/{KeyRootTag}/{key}") ?? throw new Exception("Couldn't find in XML: " + key);
            return fullUrlNode.InnerText;
        }

        public void Save()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml($"<{KeyRootTag}></{KeyRootTag}>");

            AppendNewElement(doc, KeyFullUrl, fullUrl);
            AppendNewElement(doc, KeyToken, token);
            AppendNewElement(doc, KeyAppName, appName);

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.Encoding = Encoding.UTF8;

            XmlWriter writer = XmlWriter.Create(FileName, settings);
            doc.Save(writer);
        }

        private static void AppendNewElement(XmlDocument xmlDocument, string elementName, string elementValue)
        {
            XmlElement newElem = xmlDocument.CreateElement(elementName);
            newElem.InnerText = elementValue;
            XmlElement rootElement = xmlDocument.DocumentElement ?? throw new Exception("Couldn't find root element in XML");
            rootElement.AppendChild(newElem);
        }
    }
}
