using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.DAL.BaseEntities
{
    public abstract class Entity<T> : EntityBase, IEntity<T> where T : struct
    {
        public virtual T Id { get; set; }
        public virtual string Name { get; set; }
        public virtual T CreatedBy { get; set; }
        public virtual T UptatedBy { get; set; }
        public virtual DateTime CreatedAt { get; set; }
        public virtual DateTime UptatedAt { get; set; }
    }
}
