using Xunit;
using System;
using PT_Lab4;

namespace TestProject_PT4
{
    /// <summary>
    /// Класс модульных тестов
    /// </summary>
    public class UnitTest1
    {
        /// <summary>
        /// Массив, над которым производится тестирование
        /// </summary>
        int[,] testedArray = new int[,] { { 21, 72, 13 }, { 44, 5, 86 }, { 97, 80, 39 } };
        /// <summary>
        /// Метод тестирования нахождения среднего арифметического
        /// </summary>
        [Fact]
        public void TestFindAvg()
        {
            double expected = 50;
            double actual = SquareArray.Avg_ForTesting(testedArray);
            Assert.Equal(expected, actual);
        }
        /// <summary>
        /// Метод тестирования сортировки столбцов по убыванию
        /// </summary>
        [Fact]
        public void TestSortDownward()
        {
            int[,] expectedArr = new int[,] { { 72, 21, 13 }, { 86, 44, 5 }, { 97, 80, 39 } };
            int[,] actualArr = SquareArray.SortDownward_ForTesting((int[,])testedArray.Clone());
            Assert.Equal(expectedArr, actualArr);
        }
        /// <summary>
        /// Метод тестирования умножения чётных чисел на -Т
        /// </summary>
        [Fact]
        public void TestMulEvenByMinusT()
        {
            int[,] expectedArr = new int[,] { { 21, -72, 13 }, { -44, 5, -86 }, { 97, -80, 39 } };
            int[,] actualArr = SquareArray.MultiplyEvenNumByMinusT_ForTesting((int[,])testedArray.Clone(),1);
            Assert.Equal(expectedArr, actualArr);
        }
    }
}