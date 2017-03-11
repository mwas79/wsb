using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pozycja p = new Pozycja("B5");
            Pozycja p2 = new Pozycja("D4");
            Figura f = new Pionek(p);
            Console.WriteLine(f.czymoznaprzesunac(p2));
        }
    }
}
