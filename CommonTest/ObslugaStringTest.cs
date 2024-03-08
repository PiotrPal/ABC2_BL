using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CommonTest
{
    [TestClass]
    public class ObslugaStringTest
    {
        [TestMethod]
        public void WstawSpacjeTest()
        {
            var zrodlo = "KlockiLego";
            var expected = "Klocki Lego";


            var accual = zrodlo.wstawSpacje();

            Assert.AreEqual(expected, accual);
        }

        [TestMethod]
        public void WstawSpacjeTestZeSpacja()
        {
            var zrodlo = "Klocki Lego";
            var expected = "Klocki Lego";

            var accual = zrodlo.wstawSpacje();

            Assert.AreEqual(expected, accual);
        }

    }
}
