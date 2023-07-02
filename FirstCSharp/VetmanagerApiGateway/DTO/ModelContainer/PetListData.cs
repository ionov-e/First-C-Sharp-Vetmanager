using FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer.Model;
using System.Text.Json.Serialization;

namespace FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer
{
    internal class PetListData : AbstractContainerWithModelsAndStringCount
    {
        [JsonPropertyName("pet")]
        public required Pet[] Models { get; set; }
        public override Pet[] GetModels()
        {
            return Models;
        }
    }
}
