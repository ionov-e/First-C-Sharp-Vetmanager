using FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer.Model;
using System.Text.Json.Serialization;

namespace FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer
{
    internal class ClientListData : AbstractContainerWithModelsAndStringCount
    {
        [JsonPropertyName("client")]
        public required Client[] Models { get; set; }
        public override Client[] GetModels()
        {
            return Models;
        }
    }
}

