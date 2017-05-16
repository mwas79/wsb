using System;
using System.Collections.Generic;

namespace Szachy.Klasy.Figury
{
    class Dama : Figura
    {

		public Dama(string kolor):base(kolor) {
			nazwa = "Dama";

			switch (kolor)
			{
				case KOLOR_BIALY:
					pozycja = new Pozycja("D1");
					break;
				case KOLOR_CZARNY:
					pozycja = new Pozycja("D8");
					break;
			}
		}

		public override bool sprawdzRuch(Pozycja nowaPozycja)
		{
			int pozX = pozycja.X;
			int pozY = pozycja.Y;

			List<Pozycja> mozliwePozycje = new List<Pozycja>();
            mozliwePozycje.Add(new Pozycja(pozX - 1, pozY + 1));
            mozliwePozycje.Add(new Pozycja(pozX - 2, pozY + 2));
            mozliwePozycje.Add(new Pozycja(pozX - 3, pozY + 3));
            mozliwePozycje.Add(new Pozycja(pozX - 4, pozY + 4));
			mozliwePozycje.Add(new Pozycja(pozX - 5, pozY + 5));
			mozliwePozycje.Add(new Pozycja(pozX - 6, pozY + 6));
			mozliwePozycje.Add(new Pozycja(pozX - 7, pozY + 7));
			mozliwePozycje.Add(new Pozycja(pozX - 8, pozY + 8));

			mozliwePozycje.Add(new Pozycja(pozX + 1, pozY - 1));
			mozliwePozycje.Add(new Pozycja(pozX + 2, pozY - 2));
			mozliwePozycje.Add(new Pozycja(pozX + 3, pozY - 3));
			mozliwePozycje.Add(new Pozycja(pozX + 4, pozY - 4));
			mozliwePozycje.Add(new Pozycja(pozX + 5, pozY - 5));
			mozliwePozycje.Add(new Pozycja(pozX + 6, pozY - 6));
			mozliwePozycje.Add(new Pozycja(pozX + 7, pozY - 7));
			mozliwePozycje.Add(new Pozycja(pozX + 8, pozY - 8));

			mozliwePozycje.Add(new Pozycja(pozX + 1, pozY + 1));
			mozliwePozycje.Add(new Pozycja(pozX + 2, pozY + 2));
			mozliwePozycje.Add(new Pozycja(pozX + 3, pozY + 3));
			mozliwePozycje.Add(new Pozycja(pozX + 4, pozY + 4));
			mozliwePozycje.Add(new Pozycja(pozX + 5, pozY + 5));
			mozliwePozycje.Add(new Pozycja(pozX + 6, pozY + 6));
			mozliwePozycje.Add(new Pozycja(pozX + 7, pozY + 7));
			mozliwePozycje.Add(new Pozycja(pozX + 8, pozY + 8));

			mozliwePozycje.Add(new Pozycja(pozX - 1, pozY - 1));
			mozliwePozycje.Add(new Pozycja(pozX - 2, pozY - 2));
			mozliwePozycje.Add(new Pozycja(pozX - 3, pozY - 3));
			mozliwePozycje.Add(new Pozycja(pozX - 4, pozY - 4));
			mozliwePozycje.Add(new Pozycja(pozX - 5, pozY - 5));
			mozliwePozycje.Add(new Pozycja(pozX - 6, pozY - 6));
			mozliwePozycje.Add(new Pozycja(pozX - 7, pozY - 7));
			mozliwePozycje.Add(new Pozycja(pozX - 8, pozY - 8));

			mozliwePozycje.Add(new Pozycja(pozX, 1));
			mozliwePozycje.Add(new Pozycja(pozX, 2));
			mozliwePozycje.Add(new Pozycja(pozX, 3));
			mozliwePozycje.Add(new Pozycja(pozX, 4));
			mozliwePozycje.Add(new Pozycja(pozX, 5));
			mozliwePozycje.Add(new Pozycja(pozX, 6));
			mozliwePozycje.Add(new Pozycja(pozX, 7));
			mozliwePozycje.Add(new Pozycja(pozX, 8));

			mozliwePozycje.Add(new Pozycja(1, pozY));
			mozliwePozycje.Add(new Pozycja(2, pozY));
			mozliwePozycje.Add(new Pozycja(3, pozY));
			mozliwePozycje.Add(new Pozycja(4, pozY));
			mozliwePozycje.Add(new Pozycja(5, pozY));
			mozliwePozycje.Add(new Pozycja(6, pozY));
			mozliwePozycje.Add(new Pozycja(7, pozY));
			mozliwePozycje.Add(new Pozycja(8, pozY));

			foreach (Pozycja poz in mozliwePozycje)
			{
				Console.WriteLine(poz);
				if (base.sprawdzRuch(poz) && poz.Pole == nowaPozycja.Pole)
				{
					return true;
				}
			}
			return false;
		}
    }
}
