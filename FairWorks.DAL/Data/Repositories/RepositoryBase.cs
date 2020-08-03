using FairWorks.DAL.BaseEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.DAL.Data.Repositories
{
    public class RepositoryBase<T> : IRepository<T> where T : Entity<Guid>
    {
        private readonly DbContext context;
        public RepositoryBase(DbContext _context)
        {
            context = _context;
        }
        public T Add(T entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.CreatedBy = Guid.NewGuid();
            context.Entry(entity).State = EntityState.Added;
            context.Set<T>().Add(entity);
            return entity;
        }

        public void Delete(T entity)
        {
            ChangeTrackerDetachedObject(entity);
            var dbSet = context.Set<T>();
            if (context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
        }

        public T Get(Expression<Func<T, bool>> filter = null)
        {
            return GetQueryable(filter, null, null).SingleOrDefault();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter = null)
        {
            return await GetQueryable(filter, null, null).SingleOrDefaultAsync();
        }

        public async Task<IQueryable<T>> GetAsyncQueryable(Expression<Func<T, bool>> filter = null, Expression<Func<T, object>> include = null)
        {
            var result = GetQueryable(filter, include, null);
            return await Task.FromResult(result);
        }

        protected virtual IQueryable<T> GetQueryable(
                                     Expression<Func<T, bool>> filter = null,
                                     Expression<Func<T, object>> include = null,
                                     Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                     int? skip = null,
                                     int? take = null)
        {
            IQueryable<T> query = context.Set<T>();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (include != null)
            {
                query = query.Include(include);
            }
            if (orderBy != null)
            {
                query = orderBy(query);
            }
            if (skip.HasValue)
            {
                query = query.Skip(skip.Value);
            }
            if (take.HasValue)
            {
                query = query.Take(take.Value);
            }

            return query;
        }

        public IQueryable<T> Get(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = context.Set<T>();
            foreach (var include in includes)
            {
                query = query.Include(include.Name);
            }
            return query;
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> filter = null,
            Expression<Func<T, object>> include = null)
        {
            return GetQueryable(filter, include, null);
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> filter = null, Expression<Func<T, object>> include = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, int? skip = null, int? take = null)
        {
            return GetQueryable(filter, include, orderBy, skip, take);
        }

        public virtual int Count(Expression<Func<T, bool>> filter = null)
        {
            return GetQueryable(filter).Count();
        }

        public IQueryable<T> GetAll()
        {
            return Get(null, null, null, null);
        }

        public void Update(T entity)
        {
            ChangeTrackerDetachedObject(entity);
            entity.UptatedAt = DateTime.Now;
            entity.UptatedBy = Guid.NewGuid();
            context.Entry(entity).State = EntityState.Modified;
        }

        public T GetIncludes(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = GetQueryable(filter, null, null);
            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            return query.FirstOrDefault();
        }
        public async Task<IQueryable<T>> GetIncludesAsync(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = GetQueryable(filter, null, null);
            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            return query;
        }

        private void ChangeTrackerDetachedObject(T entity)
        {
            var local = context.Set<T>().Local.FirstOrDefault(entry => entry.Id.Equals(entity.Id));
            if (local != null)
            {
                context.Entry(local).State = EntityState.Detached;
            }

        }
    }
}
