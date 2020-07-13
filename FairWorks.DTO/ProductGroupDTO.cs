using System.Collections.Generic;

namespace FairWorks.DTO
{
    public class ProductGroupDTO : BaseDTO
    {
        public string Code { get; set; }
        public List<ProductDTO> Products { get; set; }
    }
}