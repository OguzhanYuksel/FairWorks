using System.Collections.Generic;

namespace FairWorks.DTO
{
    public class CompanyProfileDTO : BaseDTO
    {
        public string Name { get; set; }
        public List<CompanyCompanyProfileDTO> CompanyCompanyProfiles { get; set; }
    }
}