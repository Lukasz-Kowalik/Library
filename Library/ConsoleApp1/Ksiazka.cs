using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Ksiazka : Pozycja
    {
        private List<Autor> autorzy = new List<Autor>();
        public int LiczbaStron { get; set; }

        public Ksiazka()
        {
        }

        public Ksiazka(string tytul_, int id_
            , string wydawnictwo_, int rokWydania_
            , int liczbaStron_)
            : base(tytul_, wydawnictwo_, id_, rokWydania_)
        {
            LiczbaStron = liczbaStron_;
        }

        public void DodajAutora(Autor autor)
        {
            autorzy.Add(autor);
        }

        public override void WypiszInfo()
        {
            Console.WriteLine(
                "ID książki: {0} " +
                "Tytuł ksiązki: {1} " +
                "Wydawnictwo: {2} " +
                "Rok wydania: {3} " +
                "Liczba stron: {4}"
                , Id, Tytul, Wydawnictwo, RokWydania, LiczbaStron);
        }
    }
}