using System;
using Szachy.Klasy.Figury;

namespace Szachy.Klasy
{
    class Szachownica
	{
        public Figura[] figury;

        //public Figura bialyKrol = new Krol("biały");
        //public Figura czarnyKrol = new Krol("czarny");
        public Figura bialyKrol = Figura.FabrykaFigurek("krol", "biały");
        public Figura czarnyKrol = Figura.FabrykaFigurek("krol", "czarny");

        //public Figura bialaDama = new Dama("biały");
        //public Figura czarnaDama = new Dama("czarny");
        public Figura bialaDama = Figura.FabrykaFigurek("dama", "biały");
        public Figura czarnaDama = Figura.FabrykaFigurek("dama", "czarny");

        //public Figura bialaWieza1 = new Wieza("biały");
        //public Figura bialaWieza2 = new Wieza("biały");
        //public Figura czarnaWieza1 = new Wieza("czarny");
        //public Figura czarnaWieza2 = new Wieza("czarny");
        public Figura bialaWieza1 = Figura.FabrykaFigurek("wieza", "biały");
        public Figura bialaWieza2 = Figura.FabrykaFigurek("wieza", "biały");
        public Figura czarnaWieza1 = Figura.FabrykaFigurek("wieza", "czarny");
        public Figura czarnaWieza2 = Figura.FabrykaFigurek("wieza", "czarny");

        //public Figura bialyGoniec1 = new Goniec("biały");
        //public Figura bialyGoniec2 = new Goniec("biały");
        //public Figura czarnyGoniec1 = new Goniec("czarny");
        //public Figura czarnyGoniec2 = new Goniec("czarny");
        public Figura bialyGoniec1 = Figura.FabrykaFigurek("goniec", "biały");
        public Figura bialyGoniec2 = Figura.FabrykaFigurek("goniec", "biały");
        public Figura czarnyGoniec1 = Figura.FabrykaFigurek("goniec", "czarny");
        public Figura czarnyGoniec2 = Figura.FabrykaFigurek("goniec", "czarny");

        public Szachownica()
		{
			foreach (Figura figura in Figura.figury)
			{
				Console.WriteLine(figura);
			}

            figury = new Figura[12];

            figury[0] = bialyKrol;
            figury[1] = czarnyKrol;
            figury[2] = bialaDama;
            figury[3] = czarnaDama;
            figury[4] = bialaWieza1;
            figury[5] = bialaWieza2;
            figury[6] = czarnaWieza1;
            figury[7] = czarnaWieza2;
            figury[8] = bialyGoniec1;
            figury[9] = bialyGoniec2;
            figury[10] = czarnyGoniec1;
            figury[11] = czarnyGoniec2;
        }

        public Figura this[int idx]
        {
            get
            {
                return this.figury[idx];
            }

            set
            {
                this.figury[idx] = value;
            }
        }
	}
    static class rozszerzenie
    {
        public static int liczFigury(this Szachownica szachownica)
        {
            return szachownica.figury.Length;
        }
    }
}
