using FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer.Model;
using System.Text.Json.Serialization;

namespace FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer
{
    internal class PetData : AbstractContainerWithOneModelAndIntCount
    {
        [JsonPropertyName("pet")]
        public required Pet Model { get; set; }
        public override Pet GetModel()
        {
            return Model;
        }
    }
}
