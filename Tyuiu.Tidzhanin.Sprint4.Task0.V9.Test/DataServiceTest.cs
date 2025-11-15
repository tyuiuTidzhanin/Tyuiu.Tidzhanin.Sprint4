using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Tidzhanin.Sprint4.Task0.V9.Lib;

namespace Tyuiu.Tidzhanin.Sprint4.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetSumEvenArrEl()
        {
            DataService ds = new DataService();
            int[] array = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
            int result = ds.GetSumEvenArrEl(array);

            int expected = 4 + 6 + 2 + 8 + 4 + 6 + 8; // Сумма четных элементов
            // Четные: 4, 6, 2, 8, 4, 6, 8
            // Нечетные: 5, 9, 7

            Assert.AreEqual(expected, result);
        }
    }
}