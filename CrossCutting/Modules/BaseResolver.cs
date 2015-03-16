namespace CrossCutting.Modules
{
    using Ninject;
    using Ninject.Modules;

    public class BaseResolver : NinjectModule
    {
        private static IKernel _kernel;

        public override void Load()
        {
            _kernel = Kernel;
        }
    }
}
