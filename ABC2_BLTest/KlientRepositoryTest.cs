using ABC2_BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ABC2_BLTest
{
    [TestClass]
    public class KlientRepositoryTest
    {
        [TestMethod]
        public void PobierzKlientaTest()
        {
            var klientRepository = new KlientRepository();
            var expected = new Klient(1)
            {
                Email = "tomekk@gmail.com",
                Imie = "Tomekk",
                Nazwisko = "Nowicki"

            };

            var accual = klientRepository.Pobierz(1);

            //Assert.AreEqual(expected, accual); to nie dzała bo to sa inne obiekty 

            Assert.AreEqual(expected.KlientID, accual.KlientID);
            Assert.AreEqual(expected.Imie, accual.Imie);
            Assert.AreEqual(expected.Nazwisko, accual.Nazwisko);
            Assert.AreEqual(expected.Email, accual.Email);
        }

        [TestMethod]
        public void PobierzKlientaAdresy()
        {
            var klientRepository = new KlientRepository();
            var expected = new Klient(1)
            {
                Email = "tomekk@gmail.com",
                Imie = "Tomekk",
                Nazwisko = "Nowicki",
                ListaAdresow = new List<Adres>()
                {
                    new Adres(1) 
                    {
                        AdresTyp= 1,
                        Ulica = "Poziomkowa",
                        Miasto = "Katowice",
                        KodPocztowy = "40-465",
                        Kraj = "Polska"
                    },
                    new Adres(2) 
                    {
                        AdresTyp = 2,
                        Ulica = "3maja",
                        Miasto = "Siedlce",
                        KodPocztowy = "80-110",
                        Kraj = "Polska"
                    }
                    
                }  

            };

            var accual = klientRepository.Pobierz(1);

            //Assert.AreEqual(expected, accual); to nie dzała bo to sa inne obiekty 

            Assert.AreEqual(expected.KlientID, accual.KlientID);
            Assert.AreEqual(expected.Imie, accual.Imie);
            Assert.AreEqual(expected.Nazwisko, accual.Nazwisko);
            Assert.AreEqual(expected.Email, accual.Email);
            for(int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.ListaAdresow[i].AdresTyp, accual.ListaAdresow[i].AdresTyp);
                Assert.AreEqual(expected.ListaAdresow[i].Ulica, accual.ListaAdresow[i].Ulica);
                Assert.AreEqual(expected.ListaAdresow[i].KodPocztowy, accual.ListaAdresow[i].KodPocztowy);
                Assert.AreEqual(expected.ListaAdresow[i].Miasto, accual.ListaAdresow[i].Miasto);
                Assert.AreEqual(expected.ListaAdresow[i].Kraj, accual.ListaAdresow[i].Kraj);
            }
        }
    }
}
