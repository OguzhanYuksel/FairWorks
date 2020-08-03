using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.DAL.BaseEntities
{
    public interface IEntity<T> where T : struct
    {
        T Id { get; set; }
    }
}
