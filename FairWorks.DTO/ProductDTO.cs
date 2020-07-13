using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.DTO
{
    public class ProductDTO : BaseDTO
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public ProductGroupDTO ProductGroup { get; set; }
        public CompanyDTO Company { get; set; }
    }
}
