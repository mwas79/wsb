using System;

namespace Szachy.Klasy
{
    class Pozycja
    {
        private int x;
        private int y;
        private string pole;

        public string Pole
        {
			get {
                return pole;
            }
            set 
			{ 
                pole = value;
                this.x = zmienX(pole);
				this.y = Int32.Parse(pole[1].ToString()); 
            }
        }

        public int X
        {
            get {
                return x;
            }
            set {
                x = value;
            }
        }
       
        public int Y
        {
            get {
                return y;
            }
            set {
                y = value;
            }
        }

        private int zmienX(string str)
        {
			switch(str[0].ToString().ToUpper()) {
                case "A":
                    return 1;
                case "B":
                    return 2;
                case "C":
                    return 3;
                case "D":
                    return 4;
                case "E":
                    return 5;
                case "F":
                    return 6;
                case "G":
                    return 7;
                case "H":
                    return 8;
                default:
					Console.WriteLine("Zła pozycja !");
					this.x = 0;
					this.y = 0;
					this.pole = "Nieznane";
                    return 0;
            }
            
        }

		public Pozycja() { }
		public Pozycja(string pole)
		{
			this.Pole = pole;
		}

		public override string ToString()
		{
			return string.Format("Pole = {0}, X = {1}, Y = {2}", Pole, X, Y);
		}

		public Pozycja(int X, int Y)
		{
			if (X > 0 && Y > 0)
			{
				this.X = X;
				this.Y = Y;

				switch (X)
				{
					case 1: this.pole = "A" + Y;
                            break;
					case 2: this.pole = "B" + Y;
                            break;
					case 3: this.pole = "C" + Y;
                            break;
					case 4: this.pole = "D" + Y;
                            break;
					case 5: this.pole = "E" + Y;
                            break;
					case 6: this.pole = "F" + Y;
                            break;
					case 7: this.pole = "G" + Y;
                            break;
					case 8: this.pole = "H" + Y;
                            break;
					default:
						this.x = 0;
						this.y = 0;
						this.pole = "Nieznane";
						break;
				}
			}
			else
			{
				this.pole = "Nieznane";
			}
		}
    }
}
