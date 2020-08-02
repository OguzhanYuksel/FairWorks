using FairWorks.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FairWorks.WebUI.Models.Interview
{
    public class InterviewEditViewModel
    {
        public InterviewDTO Interview { get; set; }
        public List<SectorDTO> Sectors { get; set; }
        public List<CompanyProfileDTO> CompanyProfiles { get; set; }
    }
}
