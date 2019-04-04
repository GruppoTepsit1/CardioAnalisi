using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardioLibrary
{
    public static class DataCardio
    {
        public static double fequenza1(double età)
        { 

            double risposta =  220 - età ;
          
            return risposta;
        }
    }

}
