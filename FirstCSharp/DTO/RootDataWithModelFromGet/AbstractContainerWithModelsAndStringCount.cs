using FirstCSharp.DTO.RootDataWithModel.Model;

namespace FirstCSharp.DTO.RootDataWithModel
{

    abstract public class AbstractContainerWithModelsAndStringCount : ContainerInterface
    {
        public required string totalCount { get; set; }
        public int TotalNumber
        {
            get { return int.Parse(totalCount); }
            set { totalCount = value.ToString(); }
        }
        abstract public AbstractModel[] GetModels();
    }
}
