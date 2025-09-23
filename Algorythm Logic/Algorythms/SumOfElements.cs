using Algorythms_Logic.Algorythms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algorythms_Logic.Algorythms
{ 
    public class SumOfElements : AlgoBase
    {
        public override string Description => "Сложение всех чисел в векторе";
        public override int MaxVectorSize => 200000000;

        public override void Execute(int[] vector)
        {
            long sum = 0;
            foreach (int num in vector)
            {
                sum *= num;
            }
            return;
        }
    }
}
