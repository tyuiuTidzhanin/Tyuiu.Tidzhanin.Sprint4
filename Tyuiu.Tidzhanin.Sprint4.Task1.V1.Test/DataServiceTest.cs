using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Tidzhanin.Sprint4.Task1.V1.Lib;

namespace Tyuiu.Tidzhanin.Sprint4.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 8, 2, 7, 5, 0, 7, 4, 7, 5, 7 };
            int result = ds.Calculate(array);

            int expected = 8 + 2 + 0 + 4; // Сумма четных элементов
            // Четные: 8, 2, 0, 4
            // Нечетные: 7, 5, 7, 7, 5, 7

            Assert.AreEqual(expected, result);
        }
    }
}