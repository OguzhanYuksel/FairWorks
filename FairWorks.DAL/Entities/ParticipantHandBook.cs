using FairWorks.DAL.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.DAL.Entities
{
    public class ParticipantHandBook : Entity<Guid>
    {
        public DateTime? SendDate { get; set; }
        public Guid PersonelId { get; set; }
        public virtual Personel Personel { get; set; }
        public DateTime? DeliverDate { get; set; }
        public bool? isDelivered { get; set; }
    }
}
