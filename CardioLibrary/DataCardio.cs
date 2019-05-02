using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardioLibrary
{
    public static class DataCardio
    {
        //Metodo per calcolare la frequenza massima
        public static string Frequenza(double eta)
        {
            double risposta = 0;
            string risp = "";
            if (eta > 0)
            {
                risposta = 220 - eta;
                risp = Convert.ToString(risposta);
            }
            else
            {
                risp = "impossibile";
            }

            return risp;
        }

        //Metodo di calcolo della frequenza massima ideale in allenamento
        public static string CalcoloMaxFrequenzaIdeale(double anni)
        {

            double frequenza = 220;
            string risp = "";

            if (anni < 0)
            {
                risp = "impossibile";
            }
            else
            {
                frequenza = frequenza - anni;
                double ideale = (frequenza / 100) * 90;
                risp = Convert.ToString(ideale);
            }
            

            return risp;
        }

        //Metodo di calcolo della frequenza minima ideale in allenamento
        public static string CalcoloMinFrequenzaIdeale(double anni)
        {
            double frequenza = 220;
            string risp = "";

            if (anni < 0)
            {
                risp = "impossibile";
            }
            else
            {
                frequenza = frequenza - anni;
                double ideale = (frequenza / 100) * 70;
                risp = Convert.ToString(ideale);
            }
            return risp;
        }

        ////Metodo per interpretare i valori della frequenza cardiaca a riposo
        public static string FrequenzaRiposo(double frequenza)
        {
            string risposta = "Normale";
            if (frequenza < 60 && frequenza > 0)
            {
                risposta = "Bradicardia";
            }
            if (frequenza <= 0)
            {
                risposta = "impossibile";
            
            }
            if (frequenza > 100)
            {
                risposta = "Tachicardia";
            }
            return risposta;
        }

        //Metodo di calcolo delle calorie bruciate in un allenamento
        public static string Esercizi(double frequenza, double peso, double età, double tempo, string sesso)
        {
            double Calorie = 0;
            string FinalValue = "";
            if (sesso == "M")
            {
                double caloriebruciate;
                double T = Math.Round(tempo / 4.184, 4);

                caloriebruciate = ((età * 0.2017) + (peso * 0.199) + (frequenza * 0.6309) - 55.0969) * T;
                Calorie = caloriebruciate;

                FinalValue = Convert.ToString(Math.Round(Calorie, 4));
            }
            else
            {
                double caloriebruciate;
                double T = Math.Round(tempo / 4.184, 4);

                caloriebruciate = ((età * 0.074) + (peso * 0.126) + (frequenza * 0.4472) - 20.4022) * T;
                Calorie = caloriebruciate;

                FinalValue = Convert.ToString(Math.Round(Calorie, 4));
            }


            if (frequenza < 45 || peso <= 0 || età <= 0 || tempo <= 0)
            {
                FinalValue = "impossibile";
            }
            return FinalValue;
        }

        //Metodo che calcola la spesa energetica nella corsa e nella camminata
        public static string MovCorsa(double peso, double chilometri)
        {
            string Calorie = "";
            if (peso <= 0 || chilometri <= 0)
            {
                Calorie = "impossibile";
            }
            else
            {
                double SpesaEnergetica = 0;
                SpesaEnergetica = 0.9 * chilometri * peso;
                Calorie = Convert.ToString(SpesaEnergetica);
            }

            return Calorie;
        }

        public static string MovCamminata(double peso, double chilometri)
        {
            string Calorie = "";
            if (peso <= 0 || chilometri <= 0)
            {
                Calorie = "impossibile";
            }
            else
            {
                double SpesaEnergetica = 0;
                SpesaEnergetica = 0.5 * chilometri * peso;
                Calorie = Convert.ToString(SpesaEnergetica);
            }

            return Calorie;
        }

        //Metodo di calcolo della media giornaliera dei battiti cardiaci
        public static string MediaBattiti(int[] BattitiGiornalieri)
        {
            int somma = 0;
            bool flag = false;
            string FinalRisp = "";

            for (int i = 0; i < BattitiGiornalieri.Length; i++)
            {
                if (BattitiGiornalieri[i] < 45)
                    flag = true;
                else
                    somma += BattitiGiornalieri[i];
            }

            if (flag == true)
            {
                FinalRisp = "impossibile";
            }
            else
            {
                double media = somma / BattitiGiornalieri.Length;
                FinalRisp = Convert.ToString(media);
            }
            return FinalRisp;
        }

        //Metodo di calcolo del battito a riposo in un array
        public static double BattitoRiposo(int[] Battiti)
        {
            int min = Battiti[0];
            for (int i = 0; i < Battiti.Length; i++)
            {
                if (min > Battiti[i])
                {
                    min = Battiti[i];
                }
            }
            return min;
        }

        //Metodo di calcolo della variabilità del battito caridaco
        public static double VariazioneBattito(int[] Battiti)
        {
            int min = Battiti[0], max = Battiti[0];
            for (int i = 0; i < Battiti.Length; i++)
            {
                if (min > Battiti[i])
                {
                    min = Battiti[i];
                }

                if (max < Battiti[i])
                {
                    max = Battiti[i];
                }
            }
            int variazione = max - min;
            return variazione;
        }

        //Metodo di riordinamento dell'array
        public static int[] Riordinamento(int[] Battiti)
        {
            int n = Battiti.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (Battiti[j] < Battiti[i])
                    {
                        int temp = Battiti[i];
                        Battiti[i] = Battiti[j];
                        Battiti[j] = temp;
                    }
                }
            }
            return Battiti;
        }

        //Recupero
        public static string Riposo(int[] battiti)
        {
            string risposta = "";
            if (battiti[5] < 90)
            {
                risposta = "ha recuperato";
            }
            else
            {
                risposta = "non ha recuperato";
            }
            return risposta;
        }
    }
}
