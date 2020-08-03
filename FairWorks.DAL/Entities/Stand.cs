using FairWorks.DAL.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.DAL.Entities
{
    public class Stand : Entity<Guid>
    {
        public string Code { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Area { get; set; }
        public Guid StandTypeId { get; set; }
        public virtual StandType StandType { get; set; }
        public Guid SalonId { get; set; }
        public virtual Salon Salon{ get; set; }
        public Guid CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public virtual Contract Contract { get; set; }
    }
}