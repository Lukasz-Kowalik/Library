namespace ConsoleApp1
{
    internal class Autor : Osoba
    {
        public string Narodowosc { get; set; }

        public Autor()
        {
        }

        public Autor(string imie, string nazwisko, string narodowosc) : base(imie, nazwisko)
        {
            Narodowosc = narodowosc;
        }
    }
}