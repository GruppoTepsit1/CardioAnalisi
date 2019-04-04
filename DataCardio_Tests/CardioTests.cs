using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardioLibrary;

namespace DataCardio_Tests
{
    [TestClass]
    public class CardioTests
    {
         
        [TestMethod]
        public void TestMethod1()
        {
            double età = 20, frequenza=200;

            double i = DataCardio.fequenza1(età);
            Assert.AreEqual(frequenza, i);
        }
    }
}
