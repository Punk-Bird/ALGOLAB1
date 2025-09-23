using Algorythms_Logic.Algorythms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algorythms_Logic.Algorythms
{
    public class MultElements : AlgoBase
    {
        public override string Description => "Перемножение всех чисел в векторе";
        public override int MaxVectorSize => 200000000;

        public override void Run(int[] vector)
        {
            long prod = 1;
            foreach (int num in vector)
            {
                prod *= num;
            }
            return;
        }
    }
}
