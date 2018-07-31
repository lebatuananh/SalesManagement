

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using SalesManagement.ConsoleApp.Infrastructure.Infrastructure.Interfaces;
using SalesManagement.ConsoleApp.Infrastructure.Infrastructure.SharedKernel;

namespace SalesManagement.ConsoleApp.Domain.Data.EF
{
    public class EFRepository<T,K>: IRepository<T,K>,IDisposable where T:DomainEntity<K>
    {
        private readonly AppDbContext _appDbContext;

        public EFRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Add(T entity)
        {
            _appDbContext.Add(entity);
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(K id)
        {
            throw new NotImplementedException();
        }

        public void RemoveMultiple(List<T> entities)
        {
            throw new NotImplementedException();
        }

        public T FindById(K id, params Expression<Func<T, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public T FindSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindAll(params Expression<Func<T, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            if(_appDbContext!=null)
                _appDbContext.Dispose();
        }
    }
}