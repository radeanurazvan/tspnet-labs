using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Lab6.Data.Repositories
{
    public interface IRepository<T>
        where T : class, IEntity
    {
        IEnumerable<T> GetAll();

        T GetById(Guid id);

        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);

        void Add(T entity);

        void Delete(Guid id);

        void SaveChanges();
    }
}