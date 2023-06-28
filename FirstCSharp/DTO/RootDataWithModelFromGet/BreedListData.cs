using FirstCSharp.DTO.RootDataWithModel.Model;
using System.Text.Json.Serialization;

namespace FirstCSharp.DTO.RootDataWithModel
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
