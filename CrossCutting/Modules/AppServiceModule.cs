using Application.AppServices;
using Application.Interfaces;
namespace CrossCutting.Modules
{
    public class AppServiceModule : BaseResolver
    {
        public override void Load()
        {
            base.Load();

            Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            Bind(typeof(IPersonAppService)).To(typeof(PersonAppService));
        }
    }
}
