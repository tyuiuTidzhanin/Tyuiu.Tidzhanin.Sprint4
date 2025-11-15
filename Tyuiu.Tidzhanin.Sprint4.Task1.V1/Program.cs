using Tyuiu.Tidzhanin.Sprint4.Task1.V1.Lib;

Console.Title = "Спринт #4 | Выполнил: Нгаргондо Тиджани | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #1                                                              *");
Console.WriteLine("* Выполнил: Нгаргондо Тиджани | ИСТНб-25-1                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
Console.WriteLine("* значениями с клавиатуры в диапазоне от 0 до 9 подсчитать сумму четных   *");
Console.WriteLine("* элементов массива.                                                      *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[] array = new int[10];
Console.WriteLine("Введите 10 целых чисел от 0 до 9:");

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент {i + 1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());

    // Проверка диапазона
    while (array[i] < 0 || array[i] > 9)
    {
        Console.Write("Число должно быть от 0 до 9. Повторите ввод: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine();
Console.Write("Введенный массив: { ");
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
int result = ds.Calculate(array);

Console.WriteLine($"Сумма четных элементов массива = {result}");

Console.ReadLine();