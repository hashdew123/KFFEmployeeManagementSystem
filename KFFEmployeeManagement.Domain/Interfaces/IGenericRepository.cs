using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace KFFEmployeeManagement.Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        IQueryable<T> GetAll();
        IQueryable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void AddRange(IQueryable<T> entities);
        void Remove(T entity);
        void RemoveRange(IQueryable<T> entities);
    }
}
