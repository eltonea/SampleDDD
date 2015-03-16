namespace Application.AppServices
{
    using Application.Interfaces;
    using Domain.Interfaces.Services;
    using System.Collections.Generic;

    public class AppServiceBase<T> : IAppServiceBase<T> where T : class
    {
        private readonly IServiceBase<T> _serviceBase;

        public AppServiceBase(IServiceBase<T> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Add(T obj)
        {
            _serviceBase.Add(obj);
            _serviceBase.SaveChanges();
        }

        public void Update(T obj)
        {
            _serviceBase.Update(obj);
            _serviceBase.SaveChanges();
        }

        public void Remove(int id)
        {
            var obj = _serviceBase.GetById(id);
            _serviceBase.Remove(obj);
            _serviceBase.SaveChanges();
        }

        public T GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _serviceBase.GetAll();
        }
    }
}
