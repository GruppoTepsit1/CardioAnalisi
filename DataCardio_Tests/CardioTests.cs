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
        [TestMethod]
        public void Testriposo2()
        {
            double frequenza = 100;
            string risposta = "Normale";
            string i = DataCardio.Normale1(frequenza);
            Assert.AreEqual(risposta, i);
        }
        [TestMethod]
        public void Testriposo3()
        {
            double frequenza = 54;
            string risposta = "Bradicardia";
            string i = DataCardio.Normale1(frequenza);
            Assert.AreEqual(risposta, i);
        }
        //test per calcolare le calorie bruciate durante le sessioni di esercizio
        [TestMethod]
        public void EserciziM()
        {
            double frequenza = 104, peso = 70, eta = 26, tempo = 36;
            string RispAsp = "255,466634799235", sesso="M";
            string i = DataCardio.EserciziM(frequenza,peso,eta,tempo,sesso);
    
            Assert.AreEqual(RispAsp,i);
        }
        [TestMethod]
        public void EserciziM1()
        {
            double frequenza = 104, peso = 70, eta = 26, tempo = 36;
            string RispAsp = "317,07017208413", sesso = "F";
            string i = DataCardio.EserciziM(frequenza, peso, eta, tempo, sesso);
            
            Assert.AreEqual(RispAsp, i);
        }
    }
}
