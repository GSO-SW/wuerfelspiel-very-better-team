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
        public void TestKonstruktor()
        {
            UcWuerfel wuerfel = new UcWuerfel();
            Assert.AreEqual(-1, wuerfel.Wert);
        }
    }
}