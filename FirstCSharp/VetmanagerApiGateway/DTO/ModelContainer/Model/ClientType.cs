using System.Text.Json.Serialization;

namespace FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer.Model
{
    public class ClientType : AbstractModel
    {
        [JsonPropertyName("title")]
        public required string Title { get; set; }
    }
}
