using FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer.Model;
using System.Text.Json.Serialization;

namespace FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer
{
    internal class PetTypeListData : AbstractContainerWithModelsAndStringCount
    {
        [JsonPropertyName("petType")]
        public required PetType[] Models { get; set; }
        public override PetType[] GetModels()
        {
            return Models;
        }
    }
}
