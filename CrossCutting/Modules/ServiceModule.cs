using Domain.Interfaces.Services;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.Modules
{
    public class ServiceModule : BaseResolver
    {
        public override void Load()
        {
            base.Load();

            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind(typeof(IPersonService)).To(typeof(PersonService));
        }
    }
}
