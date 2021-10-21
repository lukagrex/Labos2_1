using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labos2_1
{
    class KompleksniBrojKlasa
    {
        public KompleksniBrojKlasa(double realni, double imaginarni)
        {
            RealniDio = realni;
            ImaginarniDio = imaginarni;
        }
        public double RealniDio;
        public double ImaginarniDio;

        public override string ToString()
        {
            return $"({RealniDio}, {ImaginarniDio})";
        }
    }
}
