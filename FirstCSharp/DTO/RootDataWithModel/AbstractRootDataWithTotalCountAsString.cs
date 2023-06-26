using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharp.DTO.RootDataWithModel
{

    public class AbstractRootDataWithTotalCountAsString : RootDataInterface
    {
        public required string totalCount { get; set; }
        public int TotalNumber
        {
            get { return int.Parse(totalCount); }
            set { totalCount = value.ToString(); }
        }
    }
}
