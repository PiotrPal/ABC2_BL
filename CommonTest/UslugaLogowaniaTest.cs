using ABC2_BL;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CommonTest
{
    [TestClass]
    public class UslugaLogowaniaTest
    {
        [TestMethod]
        public void PiszDoPlikuTest()
        {
            var zmienioneElementy = new List<ILogowanie>();
            var klient = new Klient(5)
            {
                Email = "adamek@gmail.com",
                Imie = "Adam",
                Nazwisko = "Adamski",
                ListaAdresow = null
            };
            zmienioneElementy.Add(klient as ILogowanie);

            var produkt = new Produkt(6)
            {
                NazwaProduktu = "Lampka",
                AktualnaCena = 60.22M,
                Opis = "Lampka nocna bialo-czarna"
            };
            zmienioneElementy.Add(produkt as ILogowanie);

            var zamowienie = new Zamowienie(7)
            {
                DataZamowienia = new DateTime(2023, 01, 01)
            };
            zmienioneElementy.Add(zamowienie as ILogowanie);

            UslugaLogowanie.PiszDoPliku(zmienioneElementy);



        }
    }
}
