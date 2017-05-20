using System.Collections.Generic;
using System.Linq;

namespace Szachy.Klasy.Figury
{
    class Goniec : Figura
	{

		public Goniec(string kolor) : base(kolor) {
			nazwa = "Goniec";

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
			switch (Figura.figury.Count(f => f.kolor == kolor && f is Goniec))
			{
				case 1:
					if (kolor == KOLOR_BIALY)
					{
						pozycja = new Pozycja("C1");
					}
					else
					{
						pozycja = new Pozycja("C8");
					}
					break;
				case 2:
					if (kolor == KOLOR_BIALY)
					{
						pozycja = new Pozycja("F1");
					}
					else
					{
						pozycja = new Pozycja("F8");
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
