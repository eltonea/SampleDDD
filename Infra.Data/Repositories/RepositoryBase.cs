namespace Infra.Data.Repositories
{
    using Domain.Interfaces.Repositories;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly Context db;

        public RepositoryBase(Context cont)
        {
            db = cont;
        }

        public void Add(T obj)
        {
            db.Set<T>().Add(obj);
        }

        public void Update(T obj)
        {
            db.Entry(obj).State = EntityState.Modified;
        }

        public void Remove(T obj)
        {
            db.Set<T>().Remove(obj);
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }
    }
}
