using Algorythms_Logic.Algorythms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algorythm_Logic.Algorythms
{
    public class HornerMethod: AlgoBase
    {
        public override string Description => "Метод Горнера";
        public override int MaxVectorSize => 100000000;

        public override void Execute(int[] vector)
        {
            double x = 1.5;
            HornerMethod_(vector, x);
        }
        private static double HornerMethod_(int[] coefficients, double x)
        {
            double result = 0;

            // Проходим по коэффициентам полинома в прямом порядке
            for (int i = 0; i < coefficients.Length; i++)
            {
                result = result * x + coefficients[i];
            }

            return result;
        }
    }
}
