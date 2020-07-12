using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.DTO
{
    public class ParticipantHandBookDTO
    {
        public string Name { get; set; }
        public DateTime? SendDate { get; set; }
        public PersonelDTO Personel { get; set; }
        public DateTime? DeliverDate { get; set; }
        public bool? isDelivered { get; set; }
    }
}
