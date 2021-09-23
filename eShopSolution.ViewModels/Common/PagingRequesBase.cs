using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ViewModels.Common
{
    public class PagingRequesBase
    {
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
    }
}
