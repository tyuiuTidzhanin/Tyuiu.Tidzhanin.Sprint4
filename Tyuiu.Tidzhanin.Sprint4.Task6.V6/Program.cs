using Tyuiu.Tidzhanin.Sprint4.Task6.V6.Lib;

Console.Title = "Спринт #4 | Выполнил: Нгаргондо Тиджани | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Класс Array                                                       *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #6                                                              *");
Console.WriteLine("* Выполнил: Нгаргондо Тиджани | ИСТНб-25-1                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан строковый массив данных [\"Борис\", \"Анна\", \"Михаил\", \"Ирина\",     *");
Console.WriteLine("* \"Сергей\", \"Татьяна\", \"Олег\"], используя класс Array, выведите        *");
Console.WriteLine("* элементы массива, длина которых равна 5 символам.                       *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string[] array = { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };

Console.Write("Исходный массив: { ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"\"{array[i]}\"");
    if (i < array.Length - 1) Console.Write(", ");
}
Console.WriteLine(" }");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
string[] result = ds.Calculate(array);

Console.Write("Элементы с длиной 5 символов: { ");
for (int i = 0; i < result.Length; i++)
{
    Console.Write($"\"{result[i]}\"");
    if (i < result.Length - 1) Console.Write(", ");
}
Console.WriteLine(" }");

Console.WriteLine();
Console.WriteLine("Детальный анализ:");
foreach (string element in array)
{
    Console.WriteLine($"\"{element}\" - длина: {element.Length} символов");
}

Console.ReadLine();