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
            string finalvalue = DataCardio.CalcoloFrequenzaRiposo(frequenza);
            Assert.AreEqual(risposta, finalvalue);
        }

        [TestMethod]
        public void TestRiposoNormale()
        {
            double frequenza = 100;
            string risposta = "Normale";
            string finalvalue = DataCardio.CalcoloFrequenzaRiposo(frequenza);
            Assert.AreEqual(risposta, finalvalue);
        }

        [TestMethod]
        public void TestRiposoBradicardiaco()
        {
            double frequenza = 54;
            string risposta = "Bradicardia";
            string finalvalue = DataCardio.CalcoloFrequenzaRiposo(frequenza);
            Assert.AreEqual(risposta, finalvalue);
        }

        //test di verifica delle calorie bruciate durante un allenamento
        [TestMethod]
        public void TestCalorieBruciate1()
        {
            double frequenza = 176, peso = 80, eta = 24, tempo = 30;
            string RispAsp = "549,9708", sesso = "M";
            string finalvalue = DataCardio.Esercizi(frequenza, peso, eta, tempo, sesso);

            Assert.AreEqual(RispAsp, finalvalue);
        }

        [TestMethod]
        public void TestCalorieBruciate2()
        {
            double frequenza = 182, peso = 65, eta = 17, tempo = 30;
            string RispAsp = "545,5863", sesso = "M";
            string finalvalue = DataCardio.Esercizi(frequenza, peso, eta, tempo, sesso);

            Assert.AreEqual(RispAsp, finalvalue);
        }

        [TestMethod]
        public void TestCalorieBruciate3()
        {
            double frequenza = 182, peso = 65, eta = 17, tempo = 30;
            string RispAsp = "505,0416", sesso = "F";
            string finalvalue = DataCardio.Esercizi(frequenza, peso, eta, tempo, sesso);

            Assert.AreEqual(RispAsp, finalvalue);
        }

        //Test per verificare le calorie bruciate in una camminata
        [TestMethod]
        public void TestCalorieCamminata1()
        {
            double peso = 69;
            double chilometri = 7;

            string RispAsp = "241,5";
            string finalvalue = DataCardio.MovCamminata(peso, chilometri);

            Assert.AreEqual(RispAsp, finalvalue);
        }
        
        [TestMethod]
        public void TestCalorieCamminata2()
        {
            double peso = 73;
            double chilometri = 7;

            string RispAsp = "255,5";
            string finalvalue = DataCardio.MovCamminata(peso, chilometri);

            Assert.AreEqual(RispAsp, finalvalue);
        }

        [TestMethod]
        public void TestCalorieCamminata3()
        {
            double peso = 59.4;
            double chilometri = 4.6;

            string RispAsp = "136,62";
            string finalvalue = DataCardio.MovCamminata(peso, chilometri);

            Assert.AreEqual(RispAsp, finalvalue);
        }

        //Test per verificare le calorie bruciate in una corsa
        [TestMethod]
        public void TestCalorieCorsa1()
        {
            double peso = 78;
            double chilometri = 5;

            string RispAsp = "351";
            string finalvalue = DataCardio.MovCorsa(peso, chilometri);

            Assert.AreEqual(RispAsp, finalvalue);
        }

        [TestMethod]
        public void TestCalorieCorsa2()
        {
            double peso = 68.2;
            double chilometri = 6.9;

            string RispAsp = "423,522";
            string finalvalue = DataCardio.MovCorsa(peso, chilometri);

            Assert.AreEqual(RispAsp, finalvalue);
        }

        [TestMethod]
        public void TestCalorieCorsa3()
        {
            double peso = 84.3;
            double chilometri = 2.8;

            string RispAsp = "212,436";
            string finalvalue = DataCardio.MovCorsa(peso, chilometri);

            Assert.AreEqual(RispAsp, finalvalue);
        }

        //Test media battiti cardiaci
        [TestMethod]
        public void TestMediaBattitiCardiaci1()
        {
            int[] BattitiGiornalieri = new int[] { 67, 60, 60, 60, 60, 60, 60, 70, 75, 80, 60, 90, 120, 192, 78, 84, 97, 68, 100, 110, 145, 60, 67, 64 };
            double finalvalue = DataCardio.MediaBattiti(BattitiGiornalieri);

            double RispAsp = 82;
            Assert.AreEqual(RispAsp, finalvalue);
        }

        [TestMethod]
        public void TestMediaBattitiCardiaci2()
        {
            int[] BattitiGiornalieri = new int[] { 80, 75, 74, 78, 60, 64, 65, 68, 67, 69, 68, 78, 98, 94, 120, 145, 167, 193, 170, 68, 67, 66, 90, 75 };
            double finalvalue = DataCardio.MediaBattiti(BattitiGiornalieri);

            double RispAsp = 91;
            Assert.AreEqual(RispAsp, finalvalue);
        }

        [TestMethod]
        public void TestMediaBattitiCardiaci3()
        {
            int[] BattitiGiornalieri = new int[] { 80, 98, 65, 75, 68, 120, 145, 170, 86, 97, 68, 67, 80, 183, 120, 190, 67, 83, 74, 71, 62, 68, 67, 60 };
            double finalvalue = DataCardio.MediaBattiti(BattitiGiornalieri);

            double RispAsp = 94;
            Assert.AreEqual(RispAsp, finalvalue);
        }
    }
}
