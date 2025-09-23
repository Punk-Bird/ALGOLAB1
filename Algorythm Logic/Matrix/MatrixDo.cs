using Algorythms_Logic.Algorythms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythms_Logic.MatrixOperations
{
    public class MatrixDo : MatrixBase
    {
        public override int MaxVectorSize => 1000;
        public override string Description => "Перемножение матриц";
        public override int NumberOfOperands => 2;
        public override void Execute(params int[][,] matrices)
        {
            int[,] mx1 = matrices[0];
            int[,] mx2 = matrices[1];

            int rows1 = mx1.GetLength(0);
            int cols1 = mx1.GetLength(1);
            int rows2 = mx2.GetLength(0);
            int cols2 = mx2.GetLength(1);

            if (cols1 != rows2)
                throw new ArgumentException("Количество столбцов первой матрицы должно равняться количеству строк второй матрицы");

            int[,] result = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        sum += mx1[i, k] * mx2[k, j];
                    }
                    result[i, j] = sum;
                }
            }
        }
    }
}
