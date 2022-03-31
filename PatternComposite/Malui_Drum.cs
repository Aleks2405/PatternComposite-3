using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternComposite
{
    class Malui_Drum : IMysical_Instrument
    {
        public void Play()
        {
            Console.WriteLine("Играет малый барабан");
        }
    }
}
