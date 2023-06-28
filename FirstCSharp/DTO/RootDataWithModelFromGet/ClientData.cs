using FirstCSharp.DTO.RootDataWithModel.Model;
using System.Text.Json.Serialization;

namespace FirstCSharp.DTO.RootDataWithModel
{
    internal class ClientData : AbstractContainerWithOneModelAndIntCount
    {
        [JsonPropertyName("client")]
        public required Client Model { get; set; }

        public override Client GetModel()
        {
            return Model;
        }
    }
}
