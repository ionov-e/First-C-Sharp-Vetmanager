using FirstCSharp.DTO.RootDataWithModel.Model;
using System.Text.Json.Serialization;

namespace FirstCSharp.DTO.RootDataWithModel
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
