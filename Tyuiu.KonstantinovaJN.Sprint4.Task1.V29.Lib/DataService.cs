using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KonstantinovaJN.Sprint4.Task1.V29.Lib
{
    public class DataService : ISprint4Task1V29
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
