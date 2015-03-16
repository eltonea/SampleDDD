using Domain.Interfaces.Repositories;
using Infra.Data;
using Infra.Data.Repositories;
namespace CrossCutting.Modules
{
    public class RepositoryModule : BaseResolver
    {
        public override void Load()
        {
            base.Load();

            Bind(typeof(Context)).ToSelf();
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            Bind(typeof(IPersonRepository)).To(typeof(PersonRepository));
        }
    }
}
