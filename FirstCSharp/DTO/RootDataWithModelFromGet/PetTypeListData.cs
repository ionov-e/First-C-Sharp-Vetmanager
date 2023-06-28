using FirstCSharp.DTO.RootDataWithModel.Model;
using System.Text.Json.Serialization;

namespace FirstCSharp.DTO.RootDataWithModel
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
