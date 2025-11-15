using Tyuiu.Tidzhanin.Sprint4.Task2.V17.Lib;
using System;

Console.Title = "Спринт #4 | Выполнил: Нгаргондо Тиджани | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #17                                                             *");
Console.WriteLine("* Выполнил: Нгаргондо Тиджани | ИСТНб-25-1                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 9 элементов заполненный          *");
Console.WriteLine("* случайными числами в диапазоне от 3 до 9. Подсчитать произведение      *");
Console.WriteLine("* нечетных элементов массива.                                             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Random random = new Random();
int[] array = new int[9];

Console.Write("Сгенерированный массив: { ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(3, 10); // От 3 до 9 включительно
    Console.Write(array[i]);
    if (i < array.Length - 1) Console.Write(", ");
}
Console.WriteLine(" }");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int result = ds.Calculate(array);

Console.WriteLine($"Произведение нечетных элементов массива = {result}");

Console.ReadLine();