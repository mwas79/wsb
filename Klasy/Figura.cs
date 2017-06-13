using System;
using System.Collections.Generic;
using System.Linq;
using Szachy.Klasy.Figury;

namespace Szachy.Klasy
{
    class Figura
    {
		public string nazwa;
		public string kolor;
		public Pozycja pozycja;
		public static List<Figura> figury = new List<Figura>();
        public delegate void komruch(bool powodzenie);

		public const string KOLOR_BIALY = "biały";
		public const string KOLOR_CZARNY = "czarny";

		public Figura(string kolor)
		{
			kolor.ToLower();

			if (!(kolor == KOLOR_BIALY || kolor == KOLOR_CZARNY))
			{
				Console.WriteLine("Podano zły kolor");
				return;
			}
			else
			{
				this.kolor = kolor;
			}

			figury.Add(this);
		}

		public override string ToString()
		{
            return string.Format("Figura: {0} {1} jest na pozycji {2}", this.nazwa, this.kolor, this.pozycja.Pole);
		}

		private string FirstToUpper(string str)
		{
			return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
		}

		public virtual bool sprawdzRuch(Pozycja nowaPozycja)
		{
			if (figury.Count(f => f.pozycja.Pole == nowaPozycja.Pole) > 0)
			{
				return false;
			}
			return true;
		}

		public virtual void ruch(Pozycja nowaPozycja)
		{
            komruch komunikat = new komruch(Komunikat);

            if (this.sprawdzRuch(nowaPozycja))
			{
				this.pozycja = nowaPozycja;
                komunikat(true);

                //Console.WriteLine("Ruch: {0}({1}) został przesunięty na pole {2}", this.nazwa, this.kolor, this.pozycja.Pole);
			}
			else
			{
                komunikat(false);
                //Console.WriteLine("Błąd: Pole {0} jest zajęte lub wykracza poza dozwolony ruch dla figury: {1}.", nowaPozycja.Pole, this.nazwa);
			}
		}

        public static void Komunikat(bool powodzenie)
        {
            if(powodzenie)
            {
                Console.WriteLine("Figura została przesunięta");
            }
            else
            {
                Console.WriteLine("Błąd, pole zajęte lub poza zakresem ruchu figury");
            }
        }

        public static Figura FabrykaFigurek(string figura, string kolor)
        {
            switch (figura)
            {
                case "krol":
                    return new Krol(kolor);
                case "goniec":
                    return new Goniec(kolor);
                case "wieza":
                    return new Wieza(kolor);
                case "dama":
                    return new Dama(kolor);
                default:
                    throw new NotSupportedException("Nieprawidłowa figura !");
            }
        }

	}
}
