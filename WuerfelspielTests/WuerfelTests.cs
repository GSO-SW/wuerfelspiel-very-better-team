using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        private const int REPEAT = 1000;
        /*
        [TestMethod]
        public void Wuerfel_KannerstelltWerden()
        {
            //arrange
            bool gesichert = true;
            int letztesErbenis =1;
            //act
            Wuerfel w = new Wuerfel();
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
            Wuerfel w = new Wuerfel();
            //assert
            Assert.AreEqual(anzahlSeiten, w.AnzahlSeiten);
            Assert.AreEqual(gesichert , w.Gesichert);
            Assert.AreEqual(letztesErbenis , w.LetztesErbenis);
        }
        [TestMethod]
      
        public void Wuerfel_SeitenKleinerAls6odergroeßerals20()
        {
            //arrange
            int anzahlSeiten = 6;
            bool gesichert = true;
            int letztesErbenis = 1;
            //act
            Wuerfel w = new Wuerfel();
            //assert
            Assert.IsTrue(w.AnzahlSeiten >5 && w.AnzahlSeiten < 21);
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
            Wuerfel w = new Wuerfel();
            //assert

        }
        [TestMethod]
        public void Wuerfel_keinErgebnisAußerhalbderSeitenzahl()
        {
            //arrange
            int anzahlSeiten = 8;
            bool gesichert = true;
            int letztesErbenis = 7;
            //act
            Wuerfel w = new Wuerfel();
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
*/

        [TestMethod]
        public void Wuerfel_KannErstelltWerden()
        {
            Wuerfel w = new Wuerfel();

            Assert.IsTrue(w.Gesichert == false && w.AnzahlSeiten==6 && w.LetztesErbenis==-1);
        }
        
        [TestMethod]
        public void Wuerfel_KannErstelltWerdenMitMehrSeiten()
        {
            int i = 12;
            Wuerfel w = new Wuerfel(i);

            Assert.IsTrue(w.Gesichert == false && w.AnzahlSeiten==i && w.LetztesErbenis==-1);
        }
        [TestMethod]
        public void Wuerfel_KannWuerfeln()
        {
            Wuerfel w = new Wuerfel();

            for (int i = 0; i < REPEAT; i++)
            {
                int result=w.Wuerfeln();

                Assert.IsTrue(w.LetztesErbenis == result && w.LetztesErbenis >0 && w.LetztesErbenis <7);
            }
        }
        [TestMethod]
        public void Wuerfel_KannWuerfelnMitMehrSeiten()
        {
            for (int i = 2; i < 20; i++)
            {
                Wuerfel w = new Wuerfel(i);

                for (int j = 0; j < REPEAT; j++)
                {
                    int result=w.Wuerfeln();

                    Assert.IsTrue(w.LetztesErbenis == result && w.LetztesErbenis >0 && w.LetztesErbenis <i+1);
                }
                
            }
            
        }
    }
}
