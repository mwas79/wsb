using System;
using System.Collections.Generic;
using System.Linq;

namespace Szachy.Klasy
{
    class Figura
    {
		public string nazwa;
		public string kolor;
		public Pozycja pozycja;
		public static List<Figura> figury = new List<Figura>();

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
			if (this.sprawdzRuch(nowaPozycja))
			{
				this.pozycja = nowaPozycja;
				Console.WriteLine("Ruch: {0}({1}) został przesunięty na pole {2}", this.nazwa, this.kolor, this.pozycja.Pole);
			}
			else
			{
				Console.WriteLine("Błąd: Pole {0} jest zajęte lub wykracza poza dozwolony ruch dla figury: {1}.", nowaPozycja.Pole, this.nazwa);
			}
		}

	}
}
