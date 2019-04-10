using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardioLibrary
{
    public static class DataCardio 
    {
        public static int CalcoloFrequenzaCardiaca(int anni)
        {
            int frequenza = 220;
            frequenza = frequenza - anni;
            return frequenza;
        }

        public static double CalcoloMaxFrequenzaIdeale(double anni)
        {
            double frequenza = 220;
            frequenza = frequenza - anni;
            double ideale = (frequenza / 100) * 90;
            return ideale;
        }

        public static double CalcoloMinFrequenzaIdeale(double anni)
        {
            double frequenza = 220;
            frequenza = frequenza - anni;
            double ideale = (frequenza / 100) * 70;
            return ideale;
        }
    }
}
