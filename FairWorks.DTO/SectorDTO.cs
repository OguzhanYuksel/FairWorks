using System.Collections.Generic;

namespace FairWorks.DTO
{
    public class SectorDTO : BaseDTO
    {
        public string Name { get; set; }
        public List<CompanySectorDTO> CompanySectors { get; set; }
    }
}