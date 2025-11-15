using Tyuiu.Tidzhanin.Sprint4.Task0.V9.Lib;

Console.Title = "Спринт #4 | Выполнил: Нгаргондо Тиджани | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #9                                                              *");
Console.WriteLine("* Выполнил: Нгаргондо Тиджани | ИСТНб-25-1                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму четных   *");
Console.WriteLine("* элементов массива. {4, 6, 2, 8, 4, 5, 6, 9, 8, 7}                      *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[] array = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };

Console.Write("Массив: { ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
    if (i < array.Length - 1) Console.Write(", ");
}
Console.WriteLine(" }");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int result = ds.GetSumEvenArrEl(array);

Console.WriteLine($"Сумма четных элементов массива = {result}");

Console.ReadLine();