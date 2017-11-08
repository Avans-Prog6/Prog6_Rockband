using DependencyInjectionStarter.Library;
using System;
using System.Collections.Generic;

namespace DependencyInjectionStarter
{
    class Program
    {
        /** Testing 123 */
        static void Main()
        {
            List<IInstrument> instrumenten = new List<IInstrument>();
            instrumenten.Add(new Guitar());
            instrumenten.Add(new Guitar());
            instrumenten.Add(new BassGuitar());
            instrumenten.Add(new Drums());
            instrumenten.Add(new Vocal());


            var rockBand = new RockBand(instrumenten);
            rockBand.DoSoundCheck();
            Console.ReadLine();
        }
    }
}
