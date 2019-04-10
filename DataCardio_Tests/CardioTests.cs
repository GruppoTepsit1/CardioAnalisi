using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardioLibrary;

namespace DataCardio_Tests
{
    [TestClass]
    public class CardioTests
    {
        [TestMethod]
        public void TestBattitoCardiaco()
        {
            int anni = 12;
            int valaspettato = 208;

            int finalvalue = 0;
            finalvalue = DataCardio.CalcoloFrequenzaCardiaca(anni);
            Assert.AreEqual(valaspettato, finalvalue);
        }

        [TestMethod]
        public void TestBattitoCardiaco2()
        {
            int anni = 37;
            int valaspettato = 183;

            int finalvalue = 0;
            finalvalue = DataCardio.CalcoloFrequenzaCardiaca(anni);
            Assert.AreEqual(valaspettato, finalvalue);
        }

        [TestMethod]
        public void TestMaxFrequenzaIdeale()
        {
            double anni = 19;
            double maxfrequenzaideale = 180.9;

            double finalvalue = 0;
            finalvalue = DataCardio.CalcoloMaxFrequenzaIdeale(anni);
            Assert.AreEqual(maxfrequenzaideale, finalvalue);
        }

        [TestMethod]
        public void TestMinFrequenzaIdeale()
        {
            double anni = 19;
            double minfrequenzaideale = 141;

            double finalvalue = 0;
            finalvalue = DataCardio.CalcoloMinFrequenzaIdeale(anni);
            Assert.AreEqual(minfrequenzaideale, finalvalue);
        }
    }
}
