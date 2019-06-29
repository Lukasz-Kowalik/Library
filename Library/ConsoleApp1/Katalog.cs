using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Katalog : IZarzadzaniePozycjami
    {
        private List<Pozycja> pozycje = new List<Pozycja>();
        public string DzialTematyczny { get; set; }

        public Katalog()
        {
        }

        public Katalog(string dzialTematyczny)
        {
            DzialTematyczny = dzialTematyczny;
        }

        public Katalog(Pozycja pozycja, string dzialTematyczy)
        {
            pozycje.Add(pozycja);
            DzialTematyczny = dzialTematyczy;
        }

        public void DodajPozycje(Pozycja pozycja)
        {
            pozycje.Add(pozycja);
        }

        public void WypiszwszystkiePozycje()
        {
            foreach (var poz in pozycje)
            {
                poz.WypiszInfo();
            }
        }

        public Pozycja ZnajdzPozycjePoId(int id)
        {
            for (int i = 0; i < pozycje.Count; i++)
            {
                if (pozycje[i].Id == id)
                {
                    return pozycje[i];
                }
            }
            return null;
        }

        public Pozycja ZnajdzPozycjePoTytule(string tytul)
        {
            for (int i = 0; i < pozycje.Count; i++)
            {
                if (pozycje[i].Tytul == tytul)
                {
                    return pozycje[i];
                }
            }
            return null;
        }
    }
}