using Algorythms_Logic.Algorythms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algorythm_Logic.Algorythms
{
    public class TimSort:AlgoBase
    {
        public override string Description => "Алгоритм сортировки Timsort";
        public override int MaxVectorSize => 100000;

        public override void Run(int[] vector)
        {
            Timsort_(vector);
        }
        private static void Timsort_(int[] vector)
        {
            int minRun = CalculateMinRun(vector.Length);
            List<int[]> runs = new List<int[]>();

            
            int start = 0;
            while (start < vector.Length)
            {
                int end = FindRun(vector, start);
                int[] run = new int[end - start];
                Array.Copy(vector, start, run, 0, run.Length);
                InsertionSort(run);
                runs.Add(run);
                start = end;
            }

            while (runs.Count > 1)
            {
                int[] run1 = runs[0];
                int[] run2 = runs[1];
                runs.RemoveAt(0);
                runs.RemoveAt(0);
                int[] mergedRun = Merge(run1, run2);
                runs.Add(mergedRun);
            }

            
            if (runs.Count > 0)
            {
                Array.Copy(runs[0], 0, vector, 0, vector.Length);
            }
        }

        private static int CalculateMinRun(int n)
        {
            int r = 0;
            while (n >= 64)
            {
                r |= n & 1;
                n >>= 1;
            }
            return n + r;
        }

        private static int FindRun(int[] vector, int start)
        {
            int end = start + 1;
            if (end >= vector.Length)
                return end;

            if (vector[start] > vector[end])
            {
                while (end < vector.Length && vector[end - 1] > vector[end])
                    end++;
                Reverse(vector, start, end - 1);
            }
            else
            {
                while (end < vector.Length && vector[end - 1] <= vector[end])
                    end++;
            }

            return end;
        }

        private static void Reverse(int[] vector, int start, int end)
        {
            while (start < end)
            {
                int temp = vector[start];
                vector[start] = vector[end];
                vector[end] = temp;
                start++;
                end--;
            }
        }

        private static void InsertionSort(int[] vector)
        {
            for (int i = 1; i < vector.Length; i++)
            {
                int key = vector[i];
                int j = i - 1;
                while (j >= 0 && vector[j] > key)
                {
                    vector[j + 1] = vector[j];
                    j--;
                }
                vector[j + 1] = key;
            }
        }

        private static int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    result[k] = left[i];
                    i++;
                }
                else
                {
                    result[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < left.Length)
            {
                result[k] = left[i];
                i++;
                k++;
            }

            while (j < right.Length)
            {
                result[k] = right[j];
                j++;
                k++;
            }

            return result;
        }
    }
}
