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
            string Calorie = "";
            if (sesso == "M")
            {
                double caloriebruciate;
                double T = Math.Round(tempo / 4.184, 4);

                caloriebruciate = ((età * 0.2017) + (peso * 0.199) + (frequenza * 0.6309) - 55.0969) * T;
                Calorie = Convert.ToString(caloriebruciate);

            }
            else
            {
                double caloriebruciate;
                double T = Math.Round(tempo / 4.184, 4);
               
                caloriebruciate = ((età * 0.074) + (peso * 0.126) + (frequenza * 0.4472) - 20.4022) * T;
                Calorie = Convert.ToString(caloriebruciate);
            }
            double i = Math.Round(Calorie, 4);
            return 
        }

        public static string Movimento(double peso, double chilometri, string attività)
        {
            string Calorie = "";
            double SpesaEnergetica = 0;
            if (attività == "corsa")
            {
                SpesaEnergetica = 0.9 * chilometri * peso;
                Calorie = Convert.ToString(SpesaEnergetica);
            }
            else
            {
                SpesaEnergetica = 0.5 * chilometri * peso;
                Calorie = Convert.ToString(SpesaEnergetica);
            }
            return Calorie;
        }
    }
}
