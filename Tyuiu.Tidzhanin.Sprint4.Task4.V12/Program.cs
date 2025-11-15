using Tyuiu.Tidzhanin.Sprint4.Task4.V12.Lib;

Console.Title = "Спринт #4 | Выполнил: Нгаргондо Тиджани | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #12                                                             *");
Console.WriteLine("* Выполнил: Нгаргондо Тиджани | ИСТНб-25-1                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 8. Заменить четные элементы *");
Console.WriteLine("* массива на 1.                                                           *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[,] matrix = new int[5, 5];
Console.WriteLine("Введите 25 целых чисел от 2 до 8:");

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"Введите элемент [{i},{j}]: ");
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());

        // Проверка диапазона
        while (matrix[i, j] < 2 || matrix[i, j] > 8)
        {
            Console.Write("Число должно быть от 2 до 8. Повторите ввод: ");
            matrix[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

Console.WriteLine();
Console.WriteLine("Исходный массив:");
PrintMatrix(matrix);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int[,] result = ds.Calculate(matrix);

Console.WriteLine("Массив после замены четных элементов на 1:");
PrintMatrix(result);

Console.ReadLine();

// Метод для вывода матрицы
static void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}