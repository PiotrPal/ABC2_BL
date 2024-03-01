using ABC2_BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
    }
}
