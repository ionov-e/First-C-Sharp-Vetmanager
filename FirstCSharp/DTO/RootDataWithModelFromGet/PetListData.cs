using FirstCSharp.DTO.RootDataWithModel.Model;
using System.Text.Json.Serialization;

namespace FirstCSharp.DTO.RootDataWithModel
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
