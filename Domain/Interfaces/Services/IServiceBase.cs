using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IServiceBase<T> where T : class
    {
        void Add(T obj);
        void Update(T obj);
        void Remove(T obj);
        void SaveChanges();
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
