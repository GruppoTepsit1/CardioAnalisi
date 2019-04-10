using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardioLibrary
{
    public static class DataCardio
    {
        public static double frequenza1(double eta)
        {

            double risposta = 220 - eta;

            return risposta;
        }
        public static bool Consigliata1(double frequenzamax)
        {
            double set = 0, nov = 0, b =140;
            set = frequenzamax / 100 * 70;
            nov = frequenzamax / 100 * 90;
            bool risposta=false;
            if(b>set && b < nov)
            {
               risposta = true;
            }
            
            return risposta;
        }
        public static string Normale1(double frequenza)
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
        public static string EserciziM(double frequenza, double peso, double età, double tempo, string sesso)
        {
            string r="";
            if (sesso == "M")
            {    double caloriebruciate;
            
            caloriebruciate = (età * 0.2017 + peso * 0.199 + frequenza * 0.6309 - 55.0969) * tempo / 4.184;
            r = Convert.ToString(caloriebruciate);
            
            }
            else
            {
                double caloriebruciate;

                caloriebruciate = (età * 0.074 + peso * 0.126 + frequenza * 0.4472 - 20.4022) * tempo / 4.184;
                r = Convert.ToString(caloriebruciate);

            }
            return r;
        }
        public static string Movimento(double peso,double chilometri, string attività)
        {
            string r = "";
            double spesae = 0;
            if (attività == "corsa")
            {
                spesae = 0.9 * chilometri * peso;
                r = Convert.ToString(spesae);
            }
            else
            {
                spesae = 0.5 * chilometri * peso;
                r = Convert.ToString(spesae);
            }
            return r;
        }
    }

}
