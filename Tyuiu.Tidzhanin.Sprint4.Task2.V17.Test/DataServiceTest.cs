using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Tidzhanin.Sprint4.Task2.V17.Lib;

namespace Tyuiu.Tidzhanin.Sprint4.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();

            // Тест 1: Обычный случай
            int[] array1 = { 3, 4, 5, 6, 7, 8, 9, 4, 5 };
            int result1 = ds.Calculate(array1);
            int expected1 = 3 * 5 * 7 * 9 * 5; // 3 * 5 * 7 * 9 * 5 = 4725
            Assert.AreEqual(expected1, result1);
        }
    }
}