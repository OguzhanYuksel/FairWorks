using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.DTO
{
    public class BaseDTO 
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual Guid CreatedBy { get; set; }
        public virtual Guid UptatedBy { get; set; }
        public virtual DateTime CreatedAt { get; set; }
        public virtual DateTime UptatedAt { get; set; }
    }
}
