using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardioLibrary
{
    public static class DataCardio
    {
        public static double frequenza1(double età)
        {

            double risposta = 220 - età;

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
    }

}
