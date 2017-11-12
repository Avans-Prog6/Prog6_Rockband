using DependencyInjectionStarter.Library;
using Ninject;

namespace DependencyInjectionStarter
{
    class BandLocator
    {
        private StandardKernel _kernel;

        public BandLocator()
        {
            _kernel = new StandardKernel();
            _kernel.Bind<RockBand>().ToSelf().InSingletonScope();
            _kernel.Bind<IInstrument>().To<Guitar>();
            _kernel.Bind<IInstrument>().To<Vocal>();
        }

        public RockBand DefaultRockband
        { 
            get { return _kernel.Get<RockBand>(); }
        } 
    }
}
