using ABC2_BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
    }
}
