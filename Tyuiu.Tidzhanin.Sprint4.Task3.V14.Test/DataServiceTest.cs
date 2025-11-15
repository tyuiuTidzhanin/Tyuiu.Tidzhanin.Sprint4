using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Tidzhanin.Sprint4.Task3.V14.Lib;

namespace Tyuiu.Tidzhanin.Sprint4.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] {
                { 3, 2, 3, 3, 5 },
                { 2, 3, 3, 7, 3 },
                { 7, 5, 2, 7, 3 },
                { 4, 2, 7, 5, 2 },
                { 3, 5, 4, 2, 6 }
            };

            int result = ds.Calculate(array);
            int expected = 7; // Максимальный элемент в четвертой строке: 4, 2, 7, 5, 2 → max = 7

            Assert.AreEqual(expected, result);
        }
    }
}