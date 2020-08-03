using FairWorks.DAL.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.DAL.Entities
{
    public class Personel : Entity<Guid>
    {
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Guid PersonelTypeId { get; set; }
        public virtual PersonelType PersonelType { get; set; }
    }
}
