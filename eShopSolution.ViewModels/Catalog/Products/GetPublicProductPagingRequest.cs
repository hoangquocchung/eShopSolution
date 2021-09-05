﻿using eShopSolution.ViewModels.Catalog.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ViewModels.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequesBase
    {
        public string languageId { get; set; }
        public int? CategoryId { get; set; }
    }
}
