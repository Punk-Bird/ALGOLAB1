using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythms_Logic.Algorythms
{
    public class PermanentFunction : AlgoBase
    {
        public override string Description => "Возвращение константы";
        public override int MaxVectorSize => 100000000;
        public override void Execute(int[] vector)
        {
            long f = 1;
            for (int i = 1; i <= 10000; i++)
            {
                f *= i;
            }
            return;
        }
    }
}
