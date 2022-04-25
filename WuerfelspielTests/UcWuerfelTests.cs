using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    //testet die Klasse UcWuerfel
    [TestClass]
    public class UcWuerfelTests
    {
        //testet den Konstruktor
        [TestMethod]
        public void Test_Konstruktor()
        {
            UcWuerfel wuerfel = new UcWuerfel();
            Assert.AreEqual(-1, wuerfel.Wert);
        }
        
        //testet die Methode Wuerfeln
        
        [TestMethod]
        public void Test_Werfen()
        {
            UcWuerfel wuerfel = new UcWuerfel();
            wuerfel.Werfen();
            Assert.IsTrue(wuerfel.Wert >= 1 && wuerfel.Wert <= 6);
        }
        
        //testet die Methode btnWuerfeln_Click
        [TestMethod]
        public void Test_btnWuerfeln_Click()
        {
            UcWuerfel wuerfel = new UcWuerfel();
            //todo tests for btnWuerfeln_Click
            //wuerfel.btnWuerfeln_Click(null, null);
            Assert.IsTrue(true);
        }
        
    }
}