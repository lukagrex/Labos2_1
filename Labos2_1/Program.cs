using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labos2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            KompleksniBrojKlasa kbk1 = new KompleksniBrojKlasa(2, 4);
            KompleksniBrojStruktura kbs1 = new KompleksniBrojStruktura(3, 5);
            
            KompleksniBrojKlasa kbk2 = kbk1;
            KompleksniBrojStruktura kbs2 = kbs1;

            Console.WriteLine($"Kbk1 = {kbk1}");
            Console.WriteLine($"Kbk2 = {kbk2}");
            Console.WriteLine($"Kbs1 = {kbs1}");
            Console.WriteLine($"Kbs2 = {kbs2}");

            kbk2.RealniDio = 25;
            kbs2.ImaginarniDio = 25;

            Console.WriteLine($"Kbk1 = {kbk1}");
            Console.WriteLine($"Kbk2 = {kbk2}");
            Console.WriteLine($"Kbs1 = {kbs1}");
            Console.WriteLine($"Kbs2 = {kbs2}");
            Console.ReadKey(false);
        }
    }
}
