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
            //act
            Wuerfel w = new Wuerfel();
            //assert
            Assert.AreEqual(gesichert, w.Gesichert);
                }
        [TestMethod]
        public void WuerfelSeitenTest()
        {
            //arrange
            int anzahlSeiten = 8;
            //act
            Wuerfel w = new Wuerfel(anzahlSeiten);
            //assert
            Assert.AreEqual(anzahlSeiten, w.AnzahlSeiten);
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
