using System.Text.Json.Serialization;

namespace FirstCSharp.DTO.RootDataWithModel.Model
{
    public class ClientType : AbstractModel
    {
        [JsonPropertyName("title")]
        public required string Title { get; set; }
    }
}
