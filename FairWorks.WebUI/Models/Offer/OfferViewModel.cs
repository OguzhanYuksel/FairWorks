using FairWorks.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FairWorks.WebUI.Models.Offer
{
    public class OfferViewModel
    {
        public List<CompanyDTO> Companies { get; set; }
        public List<OfferDTO> Offers { get; set; }
        //public List<SalonDTO> Salons { get; set; }
        //public List<StandDTO> Stands { get; set; }
    }
}
