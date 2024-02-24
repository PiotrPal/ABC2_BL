using ABC2_BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ABC2_BLTest
{
    [TestClass]
    public class KlientTest
    {
        [TestMethod]
        public void NazwiskoImieTest()
        {
            //Arrange 
            Klient klient = new Klient();
            klient.Imie = "Tomasz";
            klient.Nazwisko = "Nowak";
            string expected = "Nowak, Tomasz";

            //Act
            string actual = klient.NazwiskoImie;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NazwiskoImieImiePuste()
        {
            //Arrange 
            Klient klient = new Klient();
            klient.Nazwisko = "Nowak";
            string expected = "Nowak";

            //Act
            string actual = klient.NazwiskoImie;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NazwiskoImieNazwiskoPuste()
        {
            //Arrange 
            Klient klient = new Klient();
            klient.Imie = "Tomasz";
            string expected = "Tomasz";

            //Act
            string actual = klient.NazwiskoImie;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //Arrange 
            Klient klient1 = new Klient();
            klient1.Imie = "Tomasz";
            Klient.Licznik += 1;

            Klient klient2 = new Klient();
            klient2.Imie = "Marek";
            Klient.Licznik += 1;

            Klient klient3 = new Klient();
            klient3.Imie = "Adam";
            Klient.Licznik += 1;

            //Assert
            Assert.AreEqual(3, Klient.Licznik);
        }


    }
}
