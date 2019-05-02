using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardioLibrary;

namespace DataCardio_Tests
{
    [TestClass]
    public class CardioTests
    {
        //Test per verificare la frequenza massima
        [TestMethod]
        public void TestFrequenza1()
        {
            double età = 20;
            string frequenza = "200";
            string i = DataCardio.Frequenza(età);
            Assert.AreEqual(frequenza, i);
        }

        [TestMethod]
        public void TestFrequenza2()
        {
            double età = -5;
            string frequenza = "impossibile";

            string i = DataCardio.Frequenza(età);
            Assert.AreEqual(frequenza, i);
        }

        //Tests per verificare lafrequenza massima e minima ideale durante un'allenamnto
        [TestMethod]
        public void TestMaxFrequenzaIdeale1()
        {
            double anni = 24;
            string maxfrequenzaideale = "176,4";
            string finalvalue = DataCardio.CalcoloMaxFrequenzaIdeale(anni);
            Assert.AreEqual(maxfrequenzaideale, finalvalue);
        }

        [TestMethod]
        public void TestMaxFrequenzaIdeale2()
        {
            double anni = -7;
            string maxfrequenzaideale = "impossibile";
            string finalvalue = DataCardio.CalcoloMaxFrequenzaIdeale(anni);
            Assert.AreEqual(maxfrequenzaideale, finalvalue);
        }

        [TestMethod]
        public void TestMinFrequenzaIdeale1()
        {
            double anni = 24;
            string minfrequenzaideale = "137,2";
            string finalvalue = DataCardio.CalcoloMinFrequenzaIdeale(anni);
            Assert.AreEqual(minfrequenzaideale, finalvalue);
        }

        [TestMethod]
        public void TestMinFrequenzaIdeale2()
        {
            double anni = -24;
            string minfrequenzaideale = "impossibile";
            string finalvalue = DataCardio.CalcoloMinFrequenzaIdeale(anni);
            Assert.AreEqual(minfrequenzaideale, finalvalue);
        }


        //test per verificare il battito a riposo
        [TestMethod]
        public void Testriposo1()
        {
            double frequenza = 200;
            string risposta = "Tachicardia";
            string i = DataCardio.FrequenzaRiposo(frequenza);
            Assert.AreEqual(risposta, i);
        }

        [TestMethod]
        public void Testriposo2()
        {
            double frequenza = 100;
            string risposta = "Normale";
            string i = DataCardio.FrequenzaRiposo(frequenza);
            Assert.AreEqual(risposta, i);
        }

        [TestMethod]
        public void Testriposo3()
        {
            double frequenza = 54;
            string risposta = "Bradicardia";
            string i = DataCardio.FrequenzaRiposo(frequenza);
            Assert.AreEqual(risposta, i);
        }

        [TestMethod]
        public void Testriposo4()
        {
            double frequenza = -50;
            string risposta = "impossibile";
            string i = DataCardio.FrequenzaRiposo(frequenza);
            Assert.AreEqual(risposta, i);
        }

        //Test di verifica delle calorie bruciate durante un allenamento
        [TestMethod]
        public void TestCalorieBruciate1()
        {
            double frequenza = 0, peso = 80, eta = 24, tempo = 30;
            string RispAsp = "impossibile", sesso = "M";
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
            double peso = 73;
            double chilometri = 7;

            string RispAsp = "255,5";
            string finalvalue = DataCardio.MovCamminata(peso, chilometri);

            Assert.AreEqual(RispAsp, finalvalue);
        }

        [TestMethod]
        public void TestCalorieCamminata2()
        {
            double peso = -74.6;
            double chilometri = 4.6;

            string RispAsp = "impossibile";
            string finalvalue = DataCardio.MovCamminata(peso, chilometri);

            Assert.AreEqual(RispAsp, finalvalue);
        }

        //Test per verificare le calorie bruciate in una corsa
        [TestMethod]
        public void TestCalorieCorsa1()
        {
            double peso = 68.2;
            double chilometri = 6.9;

            string RispAsp = "423,522";
            string finalvalue = DataCardio.MovCorsa(peso, chilometri);

            Assert.AreEqual(RispAsp, finalvalue);
        }

        [TestMethod]
        public void TestCalorieCorsa2()
        {
            double peso = 68.2;
            double chilometri = 0;

            string RispAsp = "impossibile";
            string finalvalue = DataCardio.MovCorsa(peso, chilometri);

            Assert.AreEqual(RispAsp, finalvalue);
        }

        //Test media battiti cardiaci
        [TestMethod]
        public void TestMediaBattitiCardiaci1()
        {
            int[] BattitiGiornalieri = new int[] { 67, 82, 77, 94, 56, 20, 84, 70, 75, 80, 60, 90, 120, 192, 78, 84, 97, 68, 100, 110, 145, 60, 67, 64 };
            string finalvalue = DataCardio.MediaBattiti(BattitiGiornalieri);

            string RispAsp = "impossibile";
            Assert.AreEqual(RispAsp, finalvalue);
        }

        [TestMethod]
        public void TestMediaBattitiCardiaci2()
        {
            int[] BattitiGiornalieri = new int[] { 80, 75, 74, 78, 60, 64, 65, 68, 67, 69, 68, 78, 98, 94, 120, 145, 167, 193, 170, 68, 67, 66, 90, 75 };
            string finalvalue = DataCardio.MediaBattiti(BattitiGiornalieri);

            string RispAsp = "91";
            Assert.AreEqual(RispAsp, finalvalue);
        }

        [TestMethod]
        public void TestMediaBattitiCardiaci3()
        {
            int[] BattitiGiornalieri = new int[] { 80, 98, 65, 75, 68, 120, 145, 170, 86, 97, 68, 67, 80, 183, 120, 190, 67, 83, 74, 71, 62, 68, 67, 60 };
            string finalvalue = DataCardio.MediaBattiti(BattitiGiornalieri);

            string RispAsp = "94";
            Assert.AreEqual(RispAsp, finalvalue);
        }

        //Test per verificare il battito a riposo
        [TestMethod]
        public void TestBattitoRiposo1()
        {
            int[] Battiti = new int[] { 95, 60, 61, 94, 72, 60 };
            double finalvalue = DataCardio.BattitoRiposo(Battiti);

            double RispAsp = 60;
            Assert.AreEqual(RispAsp, finalvalue);
        }

        [TestMethod]
        public void TestBattitoRiposo2()
        {
            int[] Battiti = new int[] { 120, 87, 94, 82, 73, 76 };
            double finalvalue = DataCardio.BattitoRiposo(Battiti);

            double RispAsp = 73;
            Assert.AreEqual(RispAsp, finalvalue);
        }

        //Metodo per verificare la variazione dei battiti
        [TestMethod]
        public void TestVariazioneBattito1()
        {
            int[] Battiti = new int[] { 120, 87, 94, 82, 73, 76 };
            double finalvalue = DataCardio.VariazioneBattito(Battiti);

            double RispAsp = 47;
            Assert.AreEqual(RispAsp, finalvalue);
        }

        [TestMethod]
        public void TestVariazioneBattito2()
        {
            int[] Battiti = new int[] { 193, 75, 68, 81, 91, 84 };
            double finalvalue = DataCardio.VariazioneBattito(Battiti);

            double RispAsp = 125;
            Assert.AreEqual(RispAsp, finalvalue);
        }

        //Test per verificare il riordinamento dei battiti
        [TestMethod]
        public void TestRiordinamentoBattiti1()
        {
            int[] Battiti = new int[] { 83, 60, 187, 94, 67 };
            int[] finalvalue = DataCardio.Riordinamento(Battiti);

            int[] RispAsp = new int[] { 60, 67, 83, 94, 187 };

            CollectionAssert.AreEqual(RispAsp, finalvalue);
        }
    }
}
