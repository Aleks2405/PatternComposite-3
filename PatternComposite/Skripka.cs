using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternComposite
{
    public class Skripka : IMysical_Instrument
    {
        public void Play()
        {
            Console.WriteLine("Играет скрипка");
        }
    }
}
