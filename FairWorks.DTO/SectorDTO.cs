using System.Collections.Generic;

namespace FairWorks.DTO
{
    public class SectorDTO
    {
        public string Name { get; set; }
        public List<CompanySectorDTO> CompanySectors { get; set; }
    }
}