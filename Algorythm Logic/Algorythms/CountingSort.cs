using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorythms_Logic.Algorythms;

namespace Algorythm_Logic.Algorythms
{
    internal class CountingSort : AlgoBase
    {
        public override string Description => "Сортировка подсчетом";

        public override int MaxVectorSize => 3000;
       
        
        public override void Run(int[] array)
        {
            _CountingSort(array);
        }
        public static void _CountingSort(int[] array)
        {
            if(array.Length == 0)
                return; 
            int max = 0;
            var size = array.Length;
            int[] output = new int[size];
            max = array[0];

                for (int i = 0; i < size; i++)
                {
                    if (array[i] > max)
                        max = array[i];
                }
            int[] count = new int[max + 1];
         
            for (int i = 0; i<size; i++)
            {
                count[array[i]]++;
            }
            for (int i = 1; i <= max; i++)
            {
                count[i] += count[i - 1];
            }
            for (int i = 0; i < size; i++)
            {
                output[count[array[i]] - 1] = array[i];
                count[array[i]]--;

            }
            for(int i = 0;i < size; i++)
            {
                array[i] = output[i];
            }
        }
    }
}
