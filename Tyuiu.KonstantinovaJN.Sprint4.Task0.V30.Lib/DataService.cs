﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KonstantinovaJN.Sprint4.Task0.V30.Lib
{
    public class DataService : ISprint4Task0V30
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
