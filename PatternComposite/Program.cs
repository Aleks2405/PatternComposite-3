using System;

namespace PatternComposite
{
    class Program
    {
        static void Main(string[] args)
        {

            Final final = new();
            final.Add(new Saxophone());
            final.Add(new Flaite());
            final.Add(new Skripka());
            final.Add(new Violiolonchel());
            final.Add(new Bolshoi_Drum());
            final.Add(new Malui_Drum());


            final.Play();
        }
    }
}
