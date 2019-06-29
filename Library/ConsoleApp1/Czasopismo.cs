using System;

namespace ConsoleApp1
{
    internal class Czasopismo : Pozycja
    {
        public int Numer { get; set; }

        public Czasopismo()
        {
        }

        public Czasopismo(string tytul_, int id_, string wydawnictwo_,
            int rokWydania_, int numer_)
            : base(tytul_, wydawnictwo_, id_, rokWydania_)
        {
            Numer = numer_;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine(
                "ID książki: {0} " +
                "Tytuł ksiązki: {1} " +
                "Wydawnictwo: {2} " +
                "Rok wydania: {3} " +
                "Liczba stron: {4}"
                , Id, Tytul, Wydawnictwo, RokWydania, Numer);
        }
    }
}