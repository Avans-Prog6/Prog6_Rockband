using DependencyInjectionStarter.Library;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionStarter
{
    class BandLocator
    {
        private StandardKernel _kernel;

        public BandLocator()
        {
            _kernel.Bind<RockBand>().ToSelf().InSingletonScope();
            _kernel.Bind<IInstrument>().To<Guitar>();
            _kernel.Bind<IInstrument>().To<Vocal>();
            _kernel.Bind<IInstrument>().To<Guitar>();
            _kernel.Bind<IInstrument>().To<Guitar>();

        }

        public RockBand DefaultRockband
        { 
            get { return _kernel.Get<RockBand>(); }
        } 
    }
}
