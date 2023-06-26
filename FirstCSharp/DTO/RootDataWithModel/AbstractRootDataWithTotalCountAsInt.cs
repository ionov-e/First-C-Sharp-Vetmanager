using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharp.DTO.RootDataWithModel
{
    public class AbstractRootDataWithTotalCountAsInt : RootDataInterface
    {
        public required int totalCount { get; set; }
        public int TotalNumber
        {
            get { return totalCount; }
            set { totalCount = value; }
        }
    }
}
