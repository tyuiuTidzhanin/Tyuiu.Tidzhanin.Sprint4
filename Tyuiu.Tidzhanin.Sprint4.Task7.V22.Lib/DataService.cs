using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.Tidzhanin.Sprint4.Task7.V22.Lib
{
    public class DataService : ISprint4Task7V22
    {
        public int Calculate(int n, int m, string value)
        {
            // Проверяем, что длина строки соответствует размеру матрицы
            if (value.Length != n * m)
            {
                throw new ArgumentException("Длина строки не соответствует размеру матрицы");
            }

            int[,] matrix = new int[n, m];
            int product = 1;
            bool hasEven = false;

            // Преобразуем строку в матрицу
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // Преобразуем символ в число
                    matrix[i, j] = int.Parse(value[index].ToString());
                    index++;

                    // Проверяем на четность и умножаем
                    if (matrix[i, j] % 2 == 0)
                    {
                        product *= matrix[i, j];
                        hasEven = true;
                    }
                }
            }

            // Если четных чисел нет, возвращаем 0
            return hasEven ? product : 0;
        }
    }
}