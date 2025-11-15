using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.Tidzhanin.Sprint4.Task6.V6.Lib
{
    public class DataService : ISprint4Task6V6
    {
        public string[] Calculate(string[] array)
        {
            // Используем класс Array для фильтрации элементов с длиной 5
            return Array.FindAll(array, element => element.Length == 5);
        }
    }
}