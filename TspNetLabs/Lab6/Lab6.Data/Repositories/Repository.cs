using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Linq.Expressions;

namespace Lab6.Data.Repositories
{
    public class Repository<T> : IRepository<T>, IDisposable
        where T : class, IEntity
    {
        protected readonly PostCommentModelContainer context;

        public Repository(PostCommentModelContainer context)
        {
            this.context = context;
        }

        public IEnumerable<T> GetAll() => DecorateEntities(context.Set<T>().AsQueryable()).ToList();

        public T GetById(Guid id) => FindBy(x => x.Id == id).FirstOrDefault();

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate) =>
            DecorateEntities(context.Set<T>().AsQueryable()).Where(predicate).ToList();

        public void Add(T entity) => context.Set<T>().Add(entity);
        
        public virtual void Delete(Guid id)
        {
            context.Set<T>().Remove(GetById(id));
        }

        public void SaveChanges() => context.SaveChanges();

        protected virtual IQueryable<T> DecorateEntities(IQueryable<T> entities) => entities;

        public void Dispose()
        {
            context?.Dispose();
        }
    }

    internal static class MissingDllHack
    {
        private static SqlProviderServices instance = SqlProviderServices.Instance;
    }
}