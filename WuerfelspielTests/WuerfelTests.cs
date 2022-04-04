using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestMethod]
        public void Wuerfel_KannerstelltWerden()
        {
            //arrange
            bool gesichert = true;
            int letztesErbenis =1;
            //act
            Wuerfel w = new Wuerfel(letztesErbenis, gesichert);
            //assert
            Assert.AreEqual(gesichert, w.Gesichert);
            Assert.AreEqual(letztesErbenis, w.LetztesErbenis);
                }
        [TestMethod]
        public void Wuerfel_WuerfelSeitenTest()
        {
            //arrange
            int anzahlSeiten = 8;
            bool gesichert = true;
            int letztesErbenis = 1;
            //act
            Wuerfel w = new Wuerfel(anzahlSeiten, letztesErbenis,gesichert);
            //assert
            Assert.AreEqual(anzahlSeiten, w.AnzahlSeiten);
            Assert.AreEqual(gesichert , w.Gesichert);
            Assert.AreEqual(letztesErbenis , w.LetztesErbenis);
        }
        [TestMethod]
      
        public void Wuerfel_SeitenKleinerAls6odergroeßerals20()
        {
            //arrange
            int anzahlSeiten = 3;
            bool gesichert = true;
            int letztesErbenis = 1;
            //act
            Wuerfel w = new Wuerfel(anzahlSeiten, letztesErbenis, gesichert);
            //assert
            Assert.IsTrue(w.AnzahlSeiten >6 && w.AnzahlSeiten < 21);
            Assert.AreEqual(gesichert, w.Gesichert);
            Assert.AreEqual(letztesErbenis, w.LetztesErbenis);
        }
        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void Wuerfel_KeineNegativesErgebnis()
        {
            //arrange
            int anzahlSeiten = 8;
            bool gesichert = true;
            int letztesErbenis = -1;
            //act
            Wuerfel w = new Wuerfel(anzahlSeiten, letztesErbenis, gesichert);
            //assert

        }
        [TestMethod]
        public void Wuerfel_keinErgebnisAußerhalbderSeitenzahl()
        {
            //arrange
            int anzahlSeiten = 8;
            bool gesichert = true;
            int letztesErbenis = 9;
            //act
            Wuerfel w = new Wuerfel(anzahlSeiten, letztesErbenis, gesichert);
            //assert
            Assert.AreEqual(anzahlSeiten, w.AnzahlSeiten);
            Assert.AreEqual(gesichert, w.Gesichert);
            Assert.IsTrue(w.LetztesErbenis > 0 && w.LetztesErbenis < anzahlSeiten);
        }
        [TestMethod]
        public void SicherungUmschaltenTests_wirdGesichert()
        {
            //arrange

            //act

            //assert

        }
        [TestMethod]
        public void Wuerfel_Wuerfeln()
        {
            //arrange

            //act 

            //assert

        }

    }
}
