using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.Tidzhanin.Sprint4.Task3.V14.Lib
{
    public class DataService : ISprint4Task3V14
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            // Четвертая строка имеет индекс 3 (так как индексация с 0)
            int fourthRow = 3;
            int maxElement = array[fourthRow, 0]; // Начинаем с первого элемента четвертой строки

            for (int j = 0; j < columns; j++)
            {
                if (array[fourthRow, j] > maxElement)
                {
                    maxElement = array[fourthRow, j];
                }
            }

            return maxElement;
        }
    }
}