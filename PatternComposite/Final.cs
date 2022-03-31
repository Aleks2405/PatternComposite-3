using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternComposite
{
    class Final : IMysical_Instrument
    {
        private IList<IMysical_Instrument> _instruments = new List<IMysical_Instrument>();

        public void Add(IMysical_Instrument instrument) =>
           _instruments.Add(instrument);

        public void Remove(IMysical_Instrument instrument) =>
            _instruments.Remove(instrument);

        public void Play()
        {
            Console.WriteLine("Играет оркестр:");
            foreach (var instrument in _instruments)
                instrument.Play();
        }
    }
}
