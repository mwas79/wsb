using System;
using Szachy.Klasy;

namespace Szachy
{
    class Program
    {
		static void Main(string[] args)
        {
			Szachownica szachownica = new Szachownica();

			szachownica.bialyKrol.ruch(new Pozycja("D2"));
			szachownica.bialyGoniec1.ruch(new Pozycja("F4"));
            szachownica.czarnaWieza1.ruch(new Pozycja("D8"));

			Console.WriteLine(szachownica.bialyKrol);
			Console.WriteLine(szachownica.bialyGoniec1);
			Console.WriteLine(szachownica.czarnaWieza1);
            Console.WriteLine(szachownica.czarnaDama);

            Console.ReadKey();
			return;
            
        }
	}
}
