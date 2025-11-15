using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.Tidzhanin.Sprint4.Task0.V9.Lib
{
    public class DataService : ISprint4Task0V9
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int sum = 0;

            foreach (int num in array)
            {
                if (num % 2 == 0) 
                {
                    sum += num;
                }
            }

            return sum;
        }
    }
}