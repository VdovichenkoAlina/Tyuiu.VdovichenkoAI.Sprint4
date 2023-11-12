using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VdovichenkoAI.Sprint4.Task5.V10.Lib
{
    public class DataService : ISprint4Task5V10
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int collumn = matrix.Length / rows;
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        count += matrix[i, j];
                    }
                }
            }
            return count;
        }
    }
}
