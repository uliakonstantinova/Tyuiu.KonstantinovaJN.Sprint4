using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KonstantinovaJN.Sprint4.Task7.V12.Lib
{
    public class DataService : ISprint4Task7V12
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mtrx = new int[n, m];

            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(index, 1));
                    index++;
                    //mtrx[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }

            int sum = 0;
            int l;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    l = mtrx[i, j];
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
