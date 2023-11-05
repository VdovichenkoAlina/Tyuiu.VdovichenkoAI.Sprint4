using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VdovichenkoAI.Sprint4.Task3.V9.Lib
{
    public class DataService : ISprint4Task3V9
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int sum = 0;
            for (int row = 0; row < array.GetLength(0); row++)
            {
                {
                    sum += array[row, 1];
                }
            }
            return sum;
        }
    }
}
