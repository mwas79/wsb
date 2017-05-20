using System;
using Szachy.Klasy.Figury;

namespace Szachy.Klasy
{
    class Szachownica
	{
		public Figura bialyKrol = new Krol("biały");
		public Figura czarnyKrol = new Krol("czarny");

		public Figura bialaDama = new Dama("biały");
		public Figura czarnaDama = new Dama("czarny");

		public Figura bialaWieza1 = new Wieza("biały");
		public Figura bialaWieza2 = new Wieza("biały");
		public Figura czarnaWieza1 = new Wieza("czarny");
		public Figura czarnaWieza2 = new Wieza("czarny");

		public Figura bialyGoniec1 = new Goniec("biały");
		public Figura bialyGoniec2 = new Goniec("biały");
		public Figura czarnyGoniec1 = new Goniec("czarny");
		public Figura czarnyGoniec2 = new Goniec("czarny");

		public Szachownica()
		{
			foreach (Figura figura in Figura.figury)
			{
				Console.WriteLine(figura);
			}
		}
	}
}
