using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardioLibrary;

namespace DataCardio_Tests
{
    [TestClass]
    public class CardioTests
    {
        [TestMethod]
        public static int CalcoloFrequenzaCardiaca(int anni)
        {
            int frequenza = 220;
            frequenza = frequenza - anni;
            return frequenza;
        }
    }
}
