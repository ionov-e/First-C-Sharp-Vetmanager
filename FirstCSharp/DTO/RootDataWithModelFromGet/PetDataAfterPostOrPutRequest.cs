using FirstCSharp.DTO.RootDataWithModel.Model;
using System.Text.Json.Serialization;

namespace FirstCSharp.DTO.RootDataWithModel
{
    internal class PetDataAfterPostOrPutRequest : AbstractContainerWithModelAndIntCount
    {
        [JsonPropertyName("pet")]
        public required Pet[] Models { get; set; }
        public override Pet GetModel()
        {
            return Models[0];
        }
    }
}
