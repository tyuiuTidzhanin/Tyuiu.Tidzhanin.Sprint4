using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Tidzhanin.Sprint4.Task4.V12.Lib;

namespace Tyuiu.Tidzhanin.Sprint4.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] {
                { 3, 6, 6, 8, 8 },
                { 2, 7, 2, 4, 6 },
                { 3, 6, 2, 6, 4 },
                { 8, 6, 2, 7, 3 },
                { 8, 7, 6, 6, 6 }
            };

            int[,] result = ds.Calculate(matrix);

            int[,] expected = new int[5, 5] {
                { 3, 1, 1, 1, 1 },
                { 1, 7, 1, 1, 1 },
                { 3, 1, 1, 1, 1 },
                { 1, 1, 1, 7, 3 },
                { 1, 7, 1, 1, 1 }
            };

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