using System.Collections.Generic;

namespace Szachy.Klasy.Figury
{
    class Krol : Figura
    {
		public Krol(string kolor):base(kolor) {
			nazwa = "Król";

			switch (kolor)
			{
				case KOLOR_BIALY:
					pozycja = new Pozycja("E1");
					break;
				case KOLOR_CZARNY:
					pozycja = new Pozycja("E8");
					break;
			}
		}

		public override bool sprawdzRuch(Pozycja nowaPozycja)
		{
			int pozX = pozycja.X;
			int pozY = pozycja.Y;

			List<Pozycja> mozliwePozycje = new List<Pozycja>();
			mozliwePozycje.Add(new Pozycja(pozX + 1, pozY));
			mozliwePozycje.Add(new Pozycja(pozX - 1, pozY));
			mozliwePozycje.Add(new Pozycja(pozX, pozY + 1));
			mozliwePozycje.Add(new Pozycja(pozX, pozY - 1));
			mozliwePozycje.Add(new Pozycja(pozX + 1, pozY + 1));
			mozliwePozycje.Add(new Pozycja(pozX - 1, pozY + 1));
			mozliwePozycje.Add(new Pozycja(pozX - 1, pozY - 1));
			mozliwePozycje.Add(new Pozycja(pozX + 1, pozY - 1));

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
