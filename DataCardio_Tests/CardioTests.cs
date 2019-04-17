using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardioLibrary;

namespace DataCardio_Tests
{
    [TestClass]
    public class CardioTests
    {
        //test per verificare la frequenza massima in base all'età di una persona
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

        //tests per verificare lafrequenza massima e minima ideale durante un'allenamnto
        [TestMethod]
        public void TestMaxFrequenzaIdeale()
        {
            double anni = 24;
            double maxfrequenzaideale = 176.4;
            double finalvalue = 0;
            finalvalue = DataCardio.CalcoloMaxFrequenzaIdeale(anni);
            Assert.AreEqual(maxfrequenzaideale, finalvalue);
        }

        [TestMethod]
        public void TestMinFrequenzaIdeale()
        {
            double anni = 24;
            double minfrequenzaideale = 137.2;

            double finalvalue = 0;
            finalvalue = DataCardio.CalcoloMinFrequenzaIdeale(anni);
            Assert.AreEqual(minfrequenzaideale, finalvalue);
        }

        //tests che verifica se una persona è bradicardiaca, normale o tachicardiaca
        public void TestRiposoTachicardiaco()
        {
            double frequenza = 200;
            string risposta = "Tachicardia";
            string i = DataCardio.CalcoloFrequenzaRiposo(frequenza);
            Assert.AreEqual(risposta, i);
        }

        [TestMethod]
        public void TestRiposoNormale()
        {
            double frequenza = 100;
            string risposta = "Normale";
            string i = DataCardio.CalcoloFrequenzaRiposo(frequenza);
            Assert.AreEqual(risposta, i);
        }

        [TestMethod]
        public void TestRiposoBradicardiaco()
        {
            double frequenza = 54;
            string risposta = "Bradicardia";
            string i = DataCardio.CalcoloFrequenzaRiposo(frequenza);
            Assert.AreEqual(risposta, i);
        }

        //test di verifica delle calorie bruciate durante un allenamento
        [TestMethod]
        public void TestCalorieBruciateM()
        {
            double frequenza = 190, peso = 60, età = 30, tempo = 45;
            string sesso = "M";
            string risposta = "Bradicardia";
            string i = DataCardio.Esercizi(frequenza, peso, età, tempo, sesso);
            Assert.AreEqual(risposta, i);
        }
    }
}
