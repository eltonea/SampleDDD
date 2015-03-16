namespace Domain.Interfaces.Repositories
{
    using System.Collections.Generic;

    public interface IRepositoryBase<T> where T : class
    {
        void Add(T obj);
        void Update(T obj);
        void Remove(T obj);
        void SaveChanges();
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
