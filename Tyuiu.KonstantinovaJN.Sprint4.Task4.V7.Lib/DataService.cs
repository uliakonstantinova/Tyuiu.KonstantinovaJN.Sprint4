using System.Timers;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KonstantinovaJN.Sprint4.Task4.V7.Lib
{
    public class DataService : ISprint4Task4V7
    {
        public int Calculate(int[,] matrix)
        {
            int sum = 0;
            int l;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    l = matrix[i, j];
                    if (l % 2 != 0)
                    {
                        sum += l;
                    }
                }

            }
            return sum;
        }
    }
}
