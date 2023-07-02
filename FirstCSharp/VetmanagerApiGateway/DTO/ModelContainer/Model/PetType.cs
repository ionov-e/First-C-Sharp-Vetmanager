using System.Text.Json.Serialization;

namespace FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer.Model
{
    public class PetType : AbstractModel
    {
        [JsonPropertyName("title")]
        public required string Title { get; set; }
        [JsonPropertyName("picture")]
        public required string Picture { get; set; }
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        [JsonPropertyName("breeds")]
        public Breed[]? Breeds { get; set; }
        public override string ToString()
        {
            return Title;
        }
    }
}
