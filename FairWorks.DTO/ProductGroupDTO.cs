using System.Collections.Generic;

namespace FairWorks.DTO
{
    public class ProductGroupDTO
    {
        public string Code { get; set; }
        public List<ProductDTO> Products { get; set; }
    }
}