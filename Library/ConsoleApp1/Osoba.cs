using System;

namespace ConsoleApp1
{
    internal class Osoba
    {
        protected string Imie { get; set; }
        protected string Nazwisko { get; set; }

        public Osoba()
        {
        }

        public Osoba(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Imie: {0} " +
                "Nazwisko: {1} ", Imie, Nazwisko);
        }
    }
}