using FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer.Model;
using System.Text.Json.Serialization;

namespace FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer
{
    internal class BreedData : AbstractContainerWithOneModelAndIntCount
    {
        [JsonPropertyName("breed")]
        public required Breed Model { get; set; }
        public override Breed GetModel()
        {
            return Model;
        }
    }
}
