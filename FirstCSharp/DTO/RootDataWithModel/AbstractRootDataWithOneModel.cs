using FirstCSharp.DTO.RootDataWithModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharp.DTO.RootDataWithModel
{
    abstract public class AbstractRootDataWithOneModel : RootDataInterface
    {
        public required int totalCount { get; set; }
        public int TotalNumber
        {
            get { return totalCount; }
            set { totalCount = value; }
        }
        abstract public ModelInterface GetModel();
    }
}
