using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KonstantinovaJN.Sprint4.Task3.V24.Lib
{
    public class DataService : ISprint4Task3V24
    {
        public int Calculate(int[,] array)
        {
            int min = array[0, 1];

            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if (array[i, 1] < min)
                    {
                        min = array[i, 1];
                    }
                }
                
            }
            return min;
        }
    }
}
