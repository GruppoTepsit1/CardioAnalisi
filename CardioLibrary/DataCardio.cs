using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardioLibrary
{
    public static class DataCardio 
    {
        public static string cardioanalisi(double eta)
        {
            string risp="";
            double Fmax=0;
           
                if (eta > 0)
                {

                    Fmax = 220 - eta;
                    risp = $"{Fmax}";
                }
                else
                {
                risp = "impossibile";
                }             
                                                
                  return risp;
        }
       
        
    }
}
