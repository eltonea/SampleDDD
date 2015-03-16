namespace Domain.Services
{
    using Domain.Entities;
    using Domain.Interfaces.Repositories;
    using Domain.Interfaces.Services;
    using System.Runtime.Remoting.Contexts;

    public class PersonService : ServiceBase<Person>, IPersonService
    {
        public PersonService(IRepositoryBase<Person> personRepository) : base(personRepository) { }
    }
}
