using System.Text.Json.Serialization;

namespace FirstCSharp.DTO.RootDataWithModel.Model
{
    public class City : AbstractModel
    {
        [JsonPropertyName("title")]
        public required string Title { get; set; }
        [JsonPropertyName("type_id")]
        public required string? TypeId { get; set; }
    }
}
