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

        public override void Execute(int[] vector)
        {
            QuickSort_(vector, 0,vector.Length-1);
        }
        private static void QuickSort_(int[] vector, int low, int high)
        {
            if (low < high)
            {
                // Находим индекс опорного элемента
                int pi = Partition(vector, low, high);

                // Рекурсивно сортируем элементы до и после опорного элемента
                QuickSort_(vector, low, pi - 1);
                QuickSort_(vector, pi + 1, high);
            }
        }
        private static int Partition(int[] vector, int low, int high)
        {
            // Опорный элемент (pivot) - последний элемент вектора
            int pivot = vector[high];
            int i = low - 1;

            for (int j=low;j<high;j++)
            {
                // Если текущий элемент меньше или равен опорному
                if (vector[j]<= pivot)
                {
                    i++;

                    // Меняем местами vector[i] и vector[j]
                    int temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                }
            }
            // Меняем местами vector[i+1] и опорный элемент (vector[high])
            int temp1 = vector[i + 1];
            vector[i + 1] = vector[high];
            vector[high] = temp1;
            return i + 1;
        }
    }
}
