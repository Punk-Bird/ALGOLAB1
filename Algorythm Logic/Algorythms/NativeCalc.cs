using Algorythms_Logic.Algorythms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algorythm_Logic.Algorythms
{
    internal class NativeCalc : AlgoBase
    {
        public override string Description => "Прямое вычисление многочлена";
        public override int MaxVectorSize => 10000000;

        public override void Run(int[] cf)
        {
            double x = 1.5;
            double result = 0;
            int degree = cf.Length - 1;

            for (int i = 0; i <= degree; i++)
            {
                result += cf[i] * Math.Pow(x, degree - i);
            }

        }
    }
}
