using System;
using System.Collections.Generic;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.Tidzhanin.Sprint4.Task6.V6.Lib
{
    public class DataService : ISprint4Task6V6
    {
        public string[] Calculate(string[] array)
        {
            List<string> resultList = new List<string>();

            foreach (string element in array)
            {
                // Точная проверка длины строки
                if (element.Length == 5)
                {
                    resultList.Add(element);
                }
            }

            return resultList.ToArray();
        }
    }
}