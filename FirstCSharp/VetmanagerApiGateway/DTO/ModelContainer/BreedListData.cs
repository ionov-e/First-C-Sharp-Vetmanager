using FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer.Model;
using System.Text.Json.Serialization;

namespace FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer
{
    internal class BreedListData : AbstractContainerWithModelsAndStringCount
    {
        [JsonPropertyName("breed")]
        public required Breed[] Models { get; set; }
        public override Breed[] GetModels()
        {
            return Models;
        }
    }
}
