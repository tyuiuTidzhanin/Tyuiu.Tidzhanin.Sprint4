using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Tidzhanin.Sprint4.Task7.V22.Lib;

namespace Tyuiu.Tidzhanin.Sprint4.Task7.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();

            int n = 5;
            int m = 3;
            string value = "695324951753684";

            int result = ds.Calculate(n, m, value);

            // Проверяем вручную:
            // Матрица 5x3:
            // 6 9 5
            // 3 2 4
            // 9 5 1
            // 7 5 3
            // 6 8 4
            // Четные числа: 6, 2, 4, 6, 8, 4
            // Произведение: 6 * 2 * 4 * 6 * 8 * 4 = 9216

            int expected = 6 * 2 * 4 * 6 * 8 * 4; // 9216

            Assert.AreEqual(expected, result);
        }
    }
}