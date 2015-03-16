namespace Application.AppServices
{
    using Application.Interfaces;
    using Domain.Entities;
    using Domain.Interfaces.Services;

    public class PersonAppService : AppServiceBase<Person>, IPersonAppService
    {
        private IPersonAppService _personAppService;

        public PersonAppService(IServiceBase<Person> personService) : base(personService) { }
    }
}
