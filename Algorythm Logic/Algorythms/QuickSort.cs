using Algorythms_Logic.Algorythms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algorythm_Logic.Algorythms
{
    public class QuickSort : AlgoBase
    {
        public override string Description => "Быстрая сортировка";
        public override int MaxVectorSize => 10000000;

        public override void Run(int[] vector)
        {
            QuickSort_(vector, 0,vector.Length-1);
        }
        private static void QuickSort_(int[] vector, int low, int high)
        {
            if (low < high)
            {
               
                int pi = Partition(vector, low, high);

               
                QuickSort_(vector, low, pi - 1);
                QuickSort_(vector, pi + 1, high);
            }
        }
        private static int Partition(int[] vector, int low, int high)
        {
           
            int pivot = vector[high];
            int i = low - 1;

            for (int j=low;j<high;j++)
            {
               
                if (vector[j]<= pivot)
                {
                    i++;

                   
                    int temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                }
            }
        
            int temp1 = vector[i + 1];
            vector[i + 1] = vector[high];
            vector[high] = temp1;
            return i + 1;
        }
    }
}
