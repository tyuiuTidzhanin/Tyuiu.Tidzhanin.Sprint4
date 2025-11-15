using Tyuiu.Tidzhanin.Sprint4.Task3.V14.Lib;

Console.Title = "Спринт #4 | Выполнил: Нгаргондо Тиджани | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #14                                                             *");
Console.WriteLine("* Выполнил: Нгаргондо Тиджани | ИСТНб-25-1                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
Console.WriteLine("* статическими значениями в диапазоне от 2 до 7. Найдите максимальный     *");
Console.WriteLine("* элемент в четвертой строке массива.                                     *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[,] array = new int[5, 5] {
    { 3, 2, 3, 3, 5 },
    { 2, 3, 3, 7, 3 },
    { 7, 5, 2, 7, 3 },
    { 4, 2, 7, 5, 2 },
    { 3, 5, 4, 2, 6 }
};

Console.WriteLine("Массив:");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"{array[i, j]}\t");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Четвертая строка (индекс 3):");
for (int j = 0; j < 5; j++)
{
    Console.Write($"{array[3, j]}\t");
}
Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int result = ds.Calculate(array);

Console.WriteLine($"Максимальный элемент в четвертой строке = {result}");

Console.ReadLine();