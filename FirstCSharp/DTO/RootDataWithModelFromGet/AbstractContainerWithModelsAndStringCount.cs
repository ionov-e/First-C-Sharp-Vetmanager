using FirstCSharp.DTO.RootDataWithModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        abstract public ModelInterface[] GetModels();
    }
}
