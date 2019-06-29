using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("\n--------------------Autor/osoba------------------");
            Osoba os = new Osoba("jan", "Taki");
            Autor a = new Autor();
            Autor aa = new Autor("Jan", "Kowalski", "polak");

            os.WypiszInfo();
            aa.WypiszInfo();
            a.WypiszInfo();

            Console.WriteLine("\n--------------------Ksiazka/czasopismo------------------");
            Ksiazka poz = new Ksiazka("tyy", 0, "Wyd", 1990, 300);
            Ksiazka poz2 = new Ksiazka("sdsad", 3, "Wydawnictwo2", 2002, 250);
            Ksiazka poz3 = new Ksiazka("Tytul2", 5, "Wydawnictwo23", 2012, 500);
            Czasopismo cza = new Czasopismo("naukowe", 1, "œwiat nauki", 2000, 32);

            poz.WypiszInfo();
            poz3.WypiszInfo();

            Console.WriteLine("\n--------------------katalog------------------");
            Katalog d = new Katalog();
            Katalog dd = new Katalog("dzial I");
            Katalog kat = new Katalog("dzial IV");

            kat.DodajPozycje(poz3);
            kat.DodajPozycje(cza);
            dd.DodajPozycje(poz);
            dd.DodajPozycje(poz2);
            dd.DodajPozycje(cza);
            poz.WypiszInfo();
            cza.WypiszInfo();
            dd.WypiszwszystkiePozycje();

            Console.WriteLine("\nSzukane pozycje z katalogu: ");

            if (dd.ZnajdzPozycjePoId(0) != null) dd.ZnajdzPozycjePoId(0).WypiszInfo();
            if (dd.ZnajdzPozycjePoId(10) != null) dd.ZnajdzPozycjePoId(10).WypiszInfo();
            if (dd.ZnajdzPozycjePoTytule("tyy") != null) dd.ZnajdzPozycjePoTytule("tyy").WypiszInfo();
            if (dd.ZnajdzPozycjePoTytule("ssss") != null) dd.ZnajdzPozycjePoTytule("ssss").WypiszInfo();

            Console.WriteLine("\n--------------------Bibliotekarz------------------");
            Bibliotekarz biblioterarz1 = new Bibliotekarz("Pawe³", "Kos", "20-03-2005", 3300);
            Bibliotekarz biblioterarz2 = new Bibliotekarz("Adam", "Kos", "20-05-2015", 3200);
            biblioterarz1.WypiszInfo();
            Console.WriteLine("\n--------------------biblioteka------------------");
            Biblioteka bib1 = new Biblioteka("Warszawa polna 1");

            biblioterarz1.WypiszInfo();
            biblioterarz2.WypiszInfo();

            bib1.DodajBibliotekarza(biblioterarz1);
            bib1.DodajBibliotekarza(biblioterarz2);
            bib1.DodajKatalog(dd);
            bib1.DodajKatalog(dd);

            bib1.WypiszInfoBibliotekarz(biblioterarz1);
            Console.WriteLine("\n----------------------------------------------");
            bib1.WypiszBibliotekarzy();
            Console.WriteLine("\n----------------------------------------------");
            bib1.WypiszwszystkiePozycje();

            Console.WriteLine("\n--------------------Wyszukiwane_pozycje--------------------------");
            Console.WriteLine("Szukane pozycje z Biblioteki: ");
            if (bib1.ZnajdzPozycjePoId(0) != null) bib1.ZnajdzPozycjePoId(0).WypiszInfo();
            if (bib1.ZnajdzPozycjePoId(10) != null) bib1.ZnajdzPozycjePoId(10).WypiszInfo();
            if (bib1.ZnajdzPozycjePoTytule("naukowe") != null) bib1.ZnajdzPozycjePoTytule("naukowe").WypiszInfo();
            if (bib1.ZnajdzPozycjePoTytule("tyy") != null) bib1.ZnajdzPozycjePoTytule("tyy").WypiszInfo();
            if (bib1.ZnajdzPozycjePoTytule("sss") != null) bib1.ZnajdzPozycjePoTytule("sss").WypiszInfo();

            Console.ReadKey();
        }
    }
}