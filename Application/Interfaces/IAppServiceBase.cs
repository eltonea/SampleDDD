namespace Application.Interfaces
{
    using System.Collections.Generic;

    public interface IAppServiceBase<T> where T : class
    {
        void Add(T obj);
        void Update(T obj);
        void Remove(int id);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
