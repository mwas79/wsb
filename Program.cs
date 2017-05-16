using System;
using Szachy.Klasy;

namespace Szachy
{
    class Program
    {
		static void Main(string[] args)
        {
			Szachownica szachownica = new Szachownica();

			//ok
			szachownica.bialyKrol.ruch(new Pozycja("C6"));
			szachownica.bialyGoniec1.ruch(new Pozycja("A3"));

			//error
			szachownica.czarnaWieza1.ruch(new Pozycja("A8"));

			Console.WriteLine(szachownica.bialyKrol);
			Console.WriteLine(szachownica.bialyGoniec1);
			Console.WriteLine(szachownica.czarnaWieza1);
            Console.ReadKey();
			return;
            
        }
	}
}
