using System;

namespace ConsoleApp1
{
    internal class Bibliotekarz : Osoba
    {
        public string DataZatrudnienia { get; set; }
        public double Wynagrodzenie { get; set; }

        public Bibliotekarz()
        {
        }

        public Bibliotekarz(string imie, string nazwisko, string dataZatrudnienia,
            double wynagrodzenie) : base(imie, nazwisko)
        {
            DataZatrudnienia = dataZatrudnienia;
            Wynagrodzenie = wynagrodzenie;
        }

        public new void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Data zatrudnienia: {0} " +
                "Wynagrodzenie: {1}", DataZatrudnienia, Wynagrodzenie);
        }
    }
}