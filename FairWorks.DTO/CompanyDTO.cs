using System;
using System.Collections.Generic;

namespace FairWorks.DTO
{
    public class CompanyDTO : BaseDTO
    {
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Fax { get; set; }
        public string TaxOffice { get; set; }
        public string TaxNumber { get; set; }

        public  List<CompanyCompanyProfileDTO> CompanyCompanyProfiles { get; set; }
        public List<CompanySectorDTO> CompanySectors { get; set; }
        public List<ContractDTO> Contracts { get; set; }
    }
}