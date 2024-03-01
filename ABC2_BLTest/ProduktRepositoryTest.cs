using ABC2_BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ABC2_BLTest
{
    [TestClass]
    public class ProduktRepositoryTest
    {
        [TestMethod]
        public void PobierzProduktTest()
        {
            var produktRepository = new ProduktRepository();
            var expected = new Produkt(2)
            {
                NazwaProduktu = "Klocki",
                Opis = "Lego samochod wyscigowy",
                AktualnaCena = 250.99M
            };

            var accual = produktRepository.Pobierz(2);

            Assert.AreEqual(expected.NazwaProduktu, accual.NazwaProduktu);
            Assert.AreEqual(expected.Opis, accual.Opis);
            Assert.AreEqual(expected.AktualnaCena, accual.AktualnaCena);
            
    }
    }
}
