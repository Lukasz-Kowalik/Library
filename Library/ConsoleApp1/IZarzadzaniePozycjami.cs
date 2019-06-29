namespace ConsoleApp1
{
    internal interface IZarzadzaniePozycjami
    {
        Pozycja ZnajdzPozycjePoId(int id);

        Pozycja ZnajdzPozycjePoTytule(string tytul);

        void WypiszwszystkiePozycje();
    }
}