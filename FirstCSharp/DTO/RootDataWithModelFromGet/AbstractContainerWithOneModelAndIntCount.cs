using FirstCSharp.DTO.RootDataWithModel.Model;

namespace FirstCSharp.DTO.RootDataWithModel
{
    abstract public class AbstractContainerWithOneModelAndIntCount : ContainerInterface
    {
        public required int totalCount { get; set; }
        public int TotalNumber
        {
            get { return totalCount; }
            set { totalCount = value; }
        }
        abstract public AbstractModel GetModel();
    }
}
