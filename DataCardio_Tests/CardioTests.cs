using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardioLibrary;

namespace DataCardio_Tests
{
    [TestClass]
    public class CardioTests
    {
        
            [TestMethod]
        public void TestFrequenzaMassima1()
        {
            double eta = 20;
            string rispattesa = "200", risp = DataCardio.cardioanalisi(eta);
            Assert.AreEqual(risp, rispattesa);



        }
        [TestMethod]
        public void TestFrequenzaMassima2()
        {
            double eta = 40;
            string rispattesa = "180", risp = DataCardio.cardioanalisi(eta);
            Assert.AreEqual(risp, rispattesa);



        }
        [TestMethod]
        public void TestFrequenzaMassima3()
        {
            double eta = -3;

            string rispattesa = "impossibile", risp = DataCardio.cardioanalisi(eta);
            Assert.AreEqual(risp, rispattesa);



        }
    }
    
}
