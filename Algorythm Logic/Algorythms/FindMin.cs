using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorythms_Logic.Algorythms;

namespace Algorythm_Logic.Algorythms
{
    internal class FindMin : AlgoBase
    {
        public override string Description => "нахождение минимального элемента в массиве";
        public override int MaxVectorSize => 1000000;
        public override void Execute(int[] array)
        {
            _FindMin(array);
        }
        public static int _FindMin(int[] array)
        {
            if (array == null || array.Length == 0)
                return -1; // Или выбросить исключение

            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }
    }

}
