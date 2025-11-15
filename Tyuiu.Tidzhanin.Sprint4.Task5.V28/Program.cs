using Tyuiu.Tidzhanin.Sprint4.Task5.V28.Lib;
using System;

Console.Title = "Спринт #4 | Выполнил: Нгаргондо Тиджани | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы (генератор случайных чисел)                     *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #28                                                             *");
Console.WriteLine("* Выполнил: Нгаргондо Тиджани | ИСТНб-25-1                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
Console.WriteLine("* случайными значениями в диапазоне от -6 до 3. Заменить отрицательные    *");
Console.WriteLine("* элементы на 0.                                                          *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Random random = new Random();
int[,] matrix = new int[5, 5];

Console.WriteLine("Сгенерированный массив:");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        matrix[i, j] = random.Next(-6, 4); // От -6 до 3 включительно
        Console.Write($"{matrix[i, j],3}");
    }
    Console.WriteLine();
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int[,] result = ds.Calculate(matrix);

Console.WriteLine("Массив после замены отрицательных элементов на 0:");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"{result[i, j],3}");
    }
    Console.WriteLine();
}

Console.ReadLine();