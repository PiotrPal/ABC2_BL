using ABC2_BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ABC2_BLTest
{
    [TestClass]
    public class ZamowienieRepositoryTest
    {
        [TestMethod]
        public void PobierzZamowienieTest()
        {
            var zamowienieRepository = new ZamowienieRepository();
            var expected = new Zamowienie(3)
            {
                DataZamowienia = new DateTimeOffset(2024, 5, 3, 14, 00, 00, new TimeSpan(7, 0, 0))
            };

            var accual = zamowienieRepository.Pobierz(3);

            Assert.AreEqual(expected.DataZamowienia, accual.DataZamowienia);
            Assert.AreEqual(expected.ZamowienieID, accual.ZamowienieID);
        }

        [TestMethod]
        public void PobierzZamowienieDoWyswietleniaTest()
        {
            var zamowienieRepository = new ZamowienieRepository();
            var expected = new WyswietlanieZamowienia()
            {
                Imie = "Marcin",
                Nazwisko = "Nowak",
                DataZamowienia = new DateTimeOffset(2024, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0)),
                AdresDostawy = new Adres()
                {
                    AdresTyp = 1,
                    Ulica = "Kosmiczna",
                    Miasto = "Warszawa",
                    KodPocztowy = "20-123",
                    Kraj = "Polska"
                },
                WyswietlaniePozycjiZamowieniaLista = new List<WyswietlaniePozycjiZamowienia>()
                {
                    new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Krzeslo",
                        IloscZamowienia = 5,
                        CenaZakupu = 69.99M
                    },
                    new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Kanapa",
                        IloscZamowienia = 1,
                        CenaZakupu = 1300.99M
                    },
                }
            };
        

            var accual = zamowienieRepository.PobierzZamowienieDoWyswietlenia(10);

            Assert.AreEqual(expected.DataZamowienia, accual.DataZamowienia);
            Assert.AreEqual(expected.ZamowienieID, accual.ZamowienieID);
            Assert.AreEqual(expected.Imie, accual.Imie);
            Assert.AreEqual(expected.Nazwisko,accual.Nazwisko);

            Assert.AreEqual(expected.AdresDostawy.AdresTyp, accual.AdresDostawy.AdresTyp);
            Assert.AreEqual(expected.AdresDostawy.Ulica, accual.AdresDostawy.Ulica);
            Assert.AreEqual(expected.AdresDostawy.KodPocztowy, accual.AdresDostawy.KodPocztowy);
            Assert.AreEqual(expected.AdresDostawy.Kraj, accual.AdresDostawy.Kraj);

            for(int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.WyswietlaniePozycjiZamowieniaLista[i].NazwaProduktu, accual.WyswietlaniePozycjiZamowieniaLista[i].NazwaProduktu);
                Assert.AreEqual(expected.WyswietlaniePozycjiZamowieniaLista[i].IloscZamowienia, accual.WyswietlaniePozycjiZamowieniaLista[i].IloscZamowienia);
                Assert.AreEqual(expected.WyswietlaniePozycjiZamowieniaLista[i].CenaZakupu, accual.WyswietlaniePozycjiZamowieniaLista[i].CenaZakupu);

            }

        }
    }
}
