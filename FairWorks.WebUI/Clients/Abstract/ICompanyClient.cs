using FairWorks.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FairWorks.WebUI.Clients.Abstract
{
    public interface ICompanyClient
    {
        Task<List<CompanyDTO>> GetAllCompanies();
        Task<CompanyDTO> AddCompany(CompanyDTO companyDTO);
        Task<List<CompanyProfileDTO>> GetAllCompanyProfiles();
    }
}
