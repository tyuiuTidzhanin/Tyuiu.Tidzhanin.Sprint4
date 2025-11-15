using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.Tidzhanin.Sprint4.Task2.V17.Lib
{
    public class DataService : ISprint4Task2V17
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            bool hasOdd = false;

            foreach (int num in array)
            {
                if (num % 2 != 0) // Проверка на нечетность
                {
                    product *= num;
                    hasOdd = true;
                }
            }

            // Если нечетных элементов нет, возвращаем 0
            return hasOdd ? product : 0;
        }
    }
}
