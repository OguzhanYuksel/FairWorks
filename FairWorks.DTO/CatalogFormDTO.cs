using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.DTO
{
    public class CatalogFormDTO : BaseDTO
    {
        public string Information { get; set; }
        public CompanyDTO Company { get; set; }
    }
}
