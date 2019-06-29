namespace ConsoleApp1
{
    internal abstract class Pozycja
    {
        protected int id;
        protected int rokWydania;
        protected string tytul;
        protected string wydawnictwo;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int RokWydania
        {
            get { return rokWydania; }
            set { rokWydania = value; }
        }

        public string Tytul
        {
            get { return tytul; }
            set { tytul = value; }
        }

        public string Wydawnictwo
        {
            get { return wydawnictwo; }
            set { wydawnictwo = value; }
        }

        public Pozycja()
        {
        }

        public Pozycja(string tytul, string wydawnictwo, int id, int rokWydania)
        {
            Tytul = tytul;
            Wydawnictwo = wydawnictwo;
            Id = id;
            RokWydania = rokWydania;
        }

        public abstract void WypiszInfo();
    }
}