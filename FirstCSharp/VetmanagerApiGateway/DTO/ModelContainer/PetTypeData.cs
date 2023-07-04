using FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer.Model;
using System.Text.Json.Serialization;

namespace FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer
{
    internal class PetTypeData : AbstractContainerWithOneModelAndIntCount
    {
        [JsonPropertyName("petType")]
        public required PetType Model { get; set; }
        public override PetType GetModel()
        {
            return Model;
        }
    }
}
