using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardioLibrary
{
    public static class DataCardio 
    {
        //Metodo di calcolo della frequenza massima
        public static int CalcoloFrequenzaCardiaca(int anni)
        {
            int frequenza = 220;
            frequenza = frequenza - anni;
            return frequenza;
        }

        //Metodo di calcolo della frequenza massima ideale in allenamento
        public static double CalcoloMaxFrequenzaIdeale(double anni)
        {
            double frequenza = 220;
            frequenza = frequenza - anni;
            double ideale = (frequenza / 100) * 90;
            return ideale;
        }

        //Metodo di calcolo della frequenza minima ideale in allenamento
        public static double CalcoloMinFrequenzaIdeale(double anni)
        {
            double frequenza = 220;
            frequenza = frequenza - anni;
            double ideale = (frequenza / 100) * 70;
            return ideale;
        }

        //Metodo per interpretare i valori della frequenza cardiaca a riposo
        public static string CalcoloFrequenzaRiposo(double frequenza)
        {
            string risposta = "Normale";
            if (frequenza < 60)
            {
                risposta = "Bradicardia";
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
            if (sesso == "M")
            {
                double caloriebruciate;
                double T = Math.Round(tempo / 4.184, 4);

                caloriebruciate = ((età * 0.2017) + (peso * 0.199) + (frequenza * 0.6309) - 55.0969) * T;
                Calorie = caloriebruciate;
            }
            else
            {
                double caloriebruciate;
                double T = Math.Round(tempo / 4.184, 4);
               
                caloriebruciate = ((età * 0.074) + (peso * 0.126) + (frequenza * 0.4472) - 20.4022) * T;
                Calorie = caloriebruciate;
            }
            string i = Convert.ToString(Math.Round(Calorie, 4));
            return i;
        }

        //Metodo che calcola la spesa energetica nella corsa e nella camminata
        public static string MovCorsa(double peso, double chilometri)
        {
            string Calorie = "";
            double SpesaEnergetica = 0;
            SpesaEnergetica = 0.9 * chilometri * peso;
            Calorie = Convert.ToString(SpesaEnergetica);

            return Calorie;
        }

        public static string MovCamminata(double peso, double chilometri)
        {
            string Calorie = "";
            double SpesaEnergetica = 0;
            SpesaEnergetica = 0.5 * chilometri * peso;
            Calorie = Convert.ToString(SpesaEnergetica);

            return Calorie;
        }

        //Metodo di calcolo della media giornaliera dei battiti cardiaci
        public static double MediaBattiti(int[] BattitiGiornalieri)
        {
            int somma = 0;
            for (int i = 0; i < BattitiGiornalieri.Length; i++)
            {
                somma += BattitiGiornalieri[i];
            }

            double media = somma / BattitiGiornalieri.Length;
            return media;
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
            Array.Sort(Battiti);
            return Battiti;
        }

        //Metodo per comunicare se una persone ha recuperato dopo un allenamento
        public static string Riposo(int[] battiti)
        {
            string risposta = " ";
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
