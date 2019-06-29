using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Biblioteka : IZarzadzaniePozycjami, IZarzadzanieBibliotekarzami
    {
        private List<Katalog> katalogi = new List<Katalog>();
        private List<Bibliotekarz> bibliotekarze = new List<Bibliotekarz>();
        public string Adres { get; set; }

        public Biblioteka()
        {
        }

        public Biblioteka(string adres)
        {
            Adres = adres;
        }

        public void DodajBibliotekarza(Bibliotekarz bibliotekarz)
        {
            bibliotekarze.Add(bibliotekarz);
        }

        public void WypiszInfoBibliotekarz(Bibliotekarz bibliotekarz)
        {
            bibliotekarz.WypiszInfo();
        }

        public void WypiszBibliotekarzy()
        {
            bibliotekarze.ForEach(WypiszInfoBibliotekarz);
        }

        public void DodajKatalog(Katalog katalog)
        {
            katalogi.Add(katalog);
        }

        public void DodajPozycje(Pozycja p, string dzialTematyczny)
        {
            katalogi.Add(new Katalog(p, dzialTematyczny));
        }

          
        public  Pozycja ZnajdzPozycjePoId(int id)
        {
            for (int i = 0; i < katalogi.Count; ++i)
            {
                if (katalogi[i].ZnajdzPozycjePoId(id) != null)
                {
                    return katalogi[i].ZnajdzPozycjePoId(id);
                }
            }
            return null;
        }

        public Pozycja ZnajdzPozycjePoTytule(string tytul)
        {
            for (int i = 0; i < katalogi.Count; ++i)
            {
                if (katalogi[i].ZnajdzPozycjePoTytule(tytul) != null)
                {
                    
                    return katalogi[i].ZnajdzPozycjePoTytule(tytul);
                }
            }
            return null;
        }

        public void WypiszwszystkiePozycje()
        {
            foreach (var i in katalogi)
            {
                i.WypiszwszystkiePozycje();
            }
        }
    }
}