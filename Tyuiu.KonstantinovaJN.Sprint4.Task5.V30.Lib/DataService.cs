using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KonstantinovaJN.Sprint4.Task5.V30.Lib
{
    public class DataService : ISprint4Task5V30
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
                    if (l >= 0)
                    {
                        sum += l;
                    }
                }

            }
            return sum;
        }
    }
}
