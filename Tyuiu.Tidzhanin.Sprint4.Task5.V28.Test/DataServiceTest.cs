using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Tidzhanin.Sprint4.Task5.V28.Lib;

namespace Tyuiu.Tidzhanin.Sprint4.Task5.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();

            // Тестовый массив с отрицательными, положительными и нулевыми элементами
            int[,] matrix = new int[5, 5] {
                { -5,  2, -3,  0, -1 },
                { -6,  1, -2,  3, -4 },
                {  0, -1,  2, -3,  1 },
                { -2,  3, -4,  1, -5 },
                {  3, -6,  0,  2, -2 }
            };

            int[,] result = ds.Calculate(matrix);

            // Ожидаемый результат: все отрицательные элементы заменены на 0
            int[,] expected = new int[5, 5] {
                { 0, 2, 0, 0, 0 },
                { 0, 1, 0, 3, 0 },
                { 0, 0, 2, 0, 1 },
                { 0, 3, 0, 1, 0 },
                { 3, 0, 0, 2, 0 }
            };

            // Сравниваем каждый элемент
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(expected[i, j], result[i, j]);
                }
            }
        }
    }
}