using System.Collections.Generic;

namespace FairWorks.DTO
{
    public class SalonDTO
    {
        public string SalonNo { get; set; }
        public int Area { get; set; }
        public SectorDTO Sector { get; set; }
        public FairDTO Fair { get; set; }
        public List<StandDTO> Stands { get; set; }
    }
}