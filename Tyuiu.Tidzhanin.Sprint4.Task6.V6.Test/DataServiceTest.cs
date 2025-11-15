using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Tidzhanin.Sprint4.Task6.V6.Lib;

namespace Tyuiu.Tidzhanin.Sprint4.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();

            string[] array = { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };
            string[] result = ds.Calculate(array);

            string[] expected = { "Борис", "Ирина", "Олег" };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}