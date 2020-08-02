using FairWorks.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FairWorks.WebUI.Models.Fair
{
    public class FairViewModel
    {
        public List<FairDTO> Fairs { get; set; }
        public List<SalonDTO> Salons { get; set; }
        public List<StandDTO> Stands { get; set; }
        public List<SectorDTO> Sectors { get; set; }

    }
}
