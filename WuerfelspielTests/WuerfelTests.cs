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
        public void WuerfelSeitenTest()
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
        public void SicherungUmschaltenTests_wirdGesichert()
        {
            //arrange

            //act

            //assert

        }
    }
}
