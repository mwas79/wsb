namespace Szachy.Klasy
{
    sealed class Toolbox
    {
        private static Szachownica szachownica = new Szachownica();

        private Toolbox()
        { }
        public static Szachownica szachownicaInst
        {
            get
            {
                return szachownica;
            }
        }
    }
}
