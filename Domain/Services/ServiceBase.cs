
namespace Domain.Services
{
    using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repositoryBase;

        public ServiceBase(IRepositoryBase<T> repoBase)
        {
            _repositoryBase = repoBase;
        }

        public void Add(T obj)
        {
            _repositoryBase.Add(obj);
        }

        public void Update(T obj)
        {
            _repositoryBase.Update(obj);
        }

        public void Remove(T obj)
        {
            _repositoryBase.Remove(obj);
        }

        public void SaveChanges()
        {
            _repositoryBase.SaveChanges();
        }

        public T GetById(int id)
        {
            return _repositoryBase.GetById(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _repositoryBase.GetAll();
        }
    }
}
