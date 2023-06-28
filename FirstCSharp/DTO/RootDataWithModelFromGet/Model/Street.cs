using System.Text.Json.Serialization;

namespace FirstCSharp.DTO.RootDataWithModel.Model
{
    public class Street : AbstractModel
    {
        [JsonPropertyName("title")]
        public required string Title { get; set; }
        [JsonPropertyName("city_id")]
        public required string CityId { get; set; }
        [JsonPropertyName("type")]
        public required string Type { get; set; }
    }
}
