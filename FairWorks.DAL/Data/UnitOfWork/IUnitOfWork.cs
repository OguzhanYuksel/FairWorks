using FairWorks.DAL.BaseEntities;
using FairWorks.DAL.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.DAL.Data.UnitOfWork
{
    public interface IUnitofWork : IDisposable
    {
        IRepository<T> GetRepository<T>() where T : Entity<Guid>;

        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
