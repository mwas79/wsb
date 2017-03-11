using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie1
{
    class Pozycja
    {
        int x;
        int y;
        string pole;

        public string Pole
        {
            get
            { return pole;
            }
            set
            {
                pole = value;
                x = PrzeliczX(pole);
                y = PrzeliczY(pole);
            }
        }
        public int x { get; }
        public int y { get; }

        internal static int PrzeliczX(string pole)
        {
            return pole[0] - 'A' + 1;
        }
        internal static int PrzeliczY(string pole)
        {
            return Int32.Parse(pole.Substring(1));
        }
        public Pozycja()
        {
            pole = null;
            x = 0;
            y = 0;

        }
        public Pozycja(string pole)
        {
            this.Pole = pole;
        }
    }
}
