using Tyuiu.Tidzhanin.Sprint4.Task7.V22.Lib;

Console.Title = "Спринт #4 | Выполнил: Нгаргондо Тиджани | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #22                                                             *");
Console.WriteLine("* Выполнил: Нгаргондо Тиджани | ИСТНб-25-1                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дана строка из одноразрядных цифр '695324951753684'. Преобразуйте ее    *");
Console.WriteLine("* в матрицу 5 на 3 и подсчитайте произведение четных чисел.               *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int n = 5; // строки
int m = 3; // столбцы
string value = "695324951753684";

Console.WriteLine($"Количество строк (n) = {n}");
Console.WriteLine($"Количество столбцов (m) = {m}");
Console.WriteLine($"Строка цифр = '{value}'");
Console.WriteLine($"Длина строки = {value.Length}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int result = ds.Calculate(n, m, value);

Console.WriteLine($"Произведение четных чисел = {result}");

// Дополнительно выведем матрицу для наглядности
Console.WriteLine();
Console.WriteLine("Матрица 5x3:");
int index = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{value[index]} ");
        index++;
    }
    Console.WriteLine();
}

Console.ReadLine();