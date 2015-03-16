namespace Infra.Data.Repositories
{
    using Domain.Entities;
    using Domain.Interfaces.Repositories;

    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(Context context) : base(context) { }
    }
}
