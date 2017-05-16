using System.Collections.Generic;
using System.Linq;

namespace Szachy.Klasy.Figury
{
    class Wieza : Figura
    {

		public Wieza(string kolor):base(kolor) {
			nazwa = "Wieża";

			switch (kolor)
			{
				case KOLOR_BIALY:
					pozycja = specifyPosition(KOLOR_BIALY);
					break;
				case KOLOR_CZARNY:
					pozycja = specifyPosition(KOLOR_CZARNY);
					break;
			}

		}

		private Pozycja specifyPosition(string kolor)
		{
			switch (Figura.figury.Count(f => f.kolor == kolor && f is Wieza))
			{
				case 1:
					if (kolor == KOLOR_BIALY)
					{
						pozycja = new Pozycja("A1");
					}
					else
					{
						pozycja = new Pozycja("A8");
					}
					break;
				case 2:
					if (kolor == KOLOR_BIALY)
					{
						pozycja = new Pozycja("H1");
					}
					else
					{
						pozycja = new Pozycja("H8");
					}
					break;

			}

			return pozycja;
		}

		public override bool sprawdzRuch(Pozycja nowaPozycja)
		{
			int pozX = pozycja.X;
			int pozY = pozycja.Y;

			List<Pozycja> mozliwePozycje = new List<Pozycja>();
			//X
			mozliwePozycje.Add(new Pozycja(1, pozY));
			mozliwePozycje.Add(new Pozycja(2, pozY));
			mozliwePozycje.Add(new Pozycja(3, pozY));
			mozliwePozycje.Add(new Pozycja(4, pozY));
			mozliwePozycje.Add(new Pozycja(5, pozY));
			mozliwePozycje.Add(new Pozycja(6, pozY));
			mozliwePozycje.Add(new Pozycja(7, pozY));
			mozliwePozycje.Add(new Pozycja(8, pozY));
			//Y
			mozliwePozycje.Add(new Pozycja(pozX, 1));
			mozliwePozycje.Add(new Pozycja(pozX, 2));
			mozliwePozycje.Add(new Pozycja(pozX, 3));
			mozliwePozycje.Add(new Pozycja(pozX, 4));
			mozliwePozycje.Add(new Pozycja(pozX, 5));
			mozliwePozycje.Add(new Pozycja(pozX, 6));
			mozliwePozycje.Add(new Pozycja(pozX, 7));
			mozliwePozycje.Add(new Pozycja(pozX, 8));

			foreach (Pozycja pos in mozliwePozycje)
			{
				if (base.sprawdzRuch(pos) && pos.Pole == nowaPozycja.Pole)
				{
					return true;
				}
			}
			return false;
		}
    }
}
