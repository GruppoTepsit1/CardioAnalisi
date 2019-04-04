using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardioLibrary;

namespace DataCardio_Tests
{
    [TestClass]
    public class CardioTests
    {
         //test per verificare la frequenza ideale in base all'età
        [TestMethod]
        public void TestFrequenza1()
        {
            double età = 20, frequenza=200;

            double i = DataCardio.frequenza1(età);
            Assert.AreEqual(frequenza, i);
        }
        [TestMethod]
        public void TestFrequenza2()
        {
            double età = 50, frequenza = 170;

            double i = DataCardio.frequenza1(età);
            Assert.AreEqual(frequenza, i);
        }
        //test per verificare la frequanza ideale, compresa tra min e max
        [TestMethod]
        public void TestIdeale1()
        {
            double  frequenzamax = 170;
            bool RespAttesa = true;
           bool i = DataCardio.Consigliata1(frequenzamax);
            Assert.AreEqual( RespAttesa, i);
        }
        //test per verificare il battito a riposo
        [TestMethod]
        public void Testriposo1()
        {
            double  frequenza = 200;
            string risposta = "Tachicardia";
            string i = DataCardio.Normale1(frequenza);
            Assert.AreEqual(risposta, i);
        }

    }
}
