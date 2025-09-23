using Algorythms_Logic.Algorythms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace Algorythm_Logic.Algorythms
{
    public class BubbleSort:AlgoBase
    {
        public override string Description => "Сортировка Пузырьком";
        public override int MaxVectorSize => 40000;

        public override void Run(int[] vector)
        {
            int n= vector.Length;
            
            
            bool swap;

            for (int i= 0;i<n-1;i++ ) 
            {
                swap = false;

                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (vector[j] > vector[j + 1])
                    {
                        
                        int temp = vector[j];
                        
                        vector[j] = vector[j + 1];
                        
                        vector[j + 1] = temp;
                        
                        swap = true;
                    }
                }
                if (!swap)
                {
                    break;
                }
            }
            return;
        }
    }
}
