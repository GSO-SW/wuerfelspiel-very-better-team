using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestMethod]
        public void WuerfelTest()
        {
            //arrange

            //act
            Wuerfel w = new Wuerfel();
            //assert

            //Assert.IsTrue(true);// is tatsächlich true :O
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
