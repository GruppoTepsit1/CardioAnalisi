using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardioLibrary;

namespace DataCardio_Tests
{
    [TestClass]
    public class CardioTests
    {
        [TestMethod]
        public void TestBattitoCardiaco1()
        {
            int anni = 12;
            int valaspettato = 208;

            int val = 0;
            val = CardioTests.CalcoloFrequenzaCardiaca(anni);
            Assert.AreEqual(valaspettato, val);
        }

        [TestMethod]
        public void TestBattitoCardiaco2()
        {
            int anni = 37;
            int valaspettato = 183;

            int val = 0;
            val = CardioTests.CalcoloFrequenzaCardiaca(anni);
            Assert.AreEqual(valaspettato, val);
        }
    }
}
