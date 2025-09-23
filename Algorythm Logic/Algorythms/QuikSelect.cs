using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorythms_Logic.Algorythms;

namespace Algorythm_Logic.Algorythms
{
    internal class QuikSelect : Algorythm
    {
        public override string Description => "алгоритм для нахождения k-го наименьшего элемента";

        public override int MaxArraySize => 100000000;
        public override void Execute(int[] array)
        {
           QuickSelect(array, 0, array.Length - 1, array.Length / 2);
        }
        private void QuickSelect(int[] array, int left, int right, int k)
        {
            if (left == right) 
            {
                return;
            }
            Random rand = new Random();
            int pivotIndex = rand.Next(left, right + 1); // Выбираем случайный опорный элемент
            pivotIndex = Partition(array, left, right, pivotIndex);
            if (k == pivotIndex) // Если опорный элемент - это k-й наименьший элемент
            {
                return; 
            }
            else if (k < pivotIndex) // Если k меньше индекса опорного элемента
            {
                QuickSelect(array, left, pivotIndex - 1, k); 
            }
            else 
            {
                QuickSelect(array, pivotIndex + 1, right, k); 
            }
        }
        private int Partition(int[] array, int left, int right, int pivotIndex)
        {
            int pivotValue = array[pivotIndex];
            // Перемещаем опорный элемент в конец
            Swap(array, pivotIndex, right);
            int storeIndex = left;
            for (int i = left; i < right; i++)
            {
                if (array[i] < pivotValue)
                {
                    Swap(array, storeIndex, i);
                    storeIndex++;
                }
            }
           
            Swap(array, right, storeIndex);
            return storeIndex;
        }
        private void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }


    }
}
