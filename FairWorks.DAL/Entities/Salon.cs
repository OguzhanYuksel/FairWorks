using FairWorks.DAL.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.DAL.Entities
{
    public class Salon : Entity<Guid>
    {
        public string SalonNo { get; set; }
        public int Area { get; set; }
        public Guid SectorId { get; set; }
        public virtual Sector Sector { get; set; }
        public Guid FairId { get; set; }
        public Fair Fair { get; set; }
        public virtual ICollection<Stand> Stands { get; set; }
    }
}
