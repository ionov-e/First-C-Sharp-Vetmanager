using System.Text.Json.Serialization;

namespace FirstCSharp.DTO.RootDataWithModel.Model
{
    public class Breed : AbstractModel
    {
        [JsonPropertyName("title")]
        public required string Title { get; set; }
        [JsonPropertyName("pet_type_id")]
        public required string PetTypeId { get; set; }
        public override string ToString()
        {
            return Title;
        }
    }
}
