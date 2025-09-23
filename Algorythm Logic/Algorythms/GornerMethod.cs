using Algorythms_Logic.Algorythms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algorythm_Logic.Algorythms
{
    public class GornerMethod: AlgoBase
    {
        public override string Description => "Метод Горнера";
        
        
        
        public override int MaxVectorSize => 100000000;

        public override void Run(int[] vector)
        {
             double x = 1.5;
            GornerFunc(vector, x);
        }
        private static double GornerFunc(int[] cf, double x)
        {
            double result = 0;

            
            for (int i = 0; i < cf.Length; i++)
            {
                result = result * x + cf[i];
            }

            return result;
        }
    }
}
