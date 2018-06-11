using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZinsZins;

namespace ZinsesZinsTest
{
    [TestClass]
    public class ZinsesZinsTest
    {
        [TestMethod]
        public void KeineLaufzeit()
        {
            //Arrange
            Zins zins = new Zins();
            int Kapital = 100;
            int Laufzeit = 0;
            int Zinsen = 5;
            //Act
            var ergebnis = zins.BerechneZins(Kapital, Laufzeit, Zinsen);
            //Assert
            Assert.AreEqual(Kapital, ergebnis);
        }

        [TestMethod]
        public void EinJahr()
        {
            Zins zins = new Zins();
            int Kapital = 100;
            int Laufzeit = 1;
            int Zinsen = 5;
            //Act
            var ergebnis = zins.BerechneZins(Kapital, Laufzeit, Zinsen);
            //Assert
            Assert.AreEqual(105, ergebnis);
        }

        [TestMethod]
        public void SiebenJahre()
        {
            Zins zins = new Zins();
            int Kapital = 100;
            int Laufzeit = 7;
            int Zinsen = 5;
            //Act
            var ergebnis = zins.BerechneZins(Kapital, Laufzeit, Zinsen);
            //Assert
            Assert.AreEqual(140.71, ergebnis);
        }

        [TestMethod]
        public void NegativeLaufzeit()
        {
            //Arrange
            Zins zins = new Zins();
            int Kapital = 100;
            int Laufzeit = -1;
            int Zinsen = 5;
            //Act
            var ergebnis = zins.BerechneZins(Kapital, Laufzeit, Zinsen);
            //Assert
            Assert.AreEqual(Kapital, ergebnis);
        }
    }
}
