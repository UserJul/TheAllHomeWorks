using NUnit.Framework;
using System;

namespace HomeWork2.Tests2
{
    public class Tests
    {
        private HW2 _hw2;
       
        [SetUp]
        public void Setup()
        {
            _hw2 = new HW2();
        }
        [TestCase(5, 4, 9)]
        [TestCase(5, 5, 25)]
        [TestCase(20, 24, -4)]
        public void CountsABTest(double a, double b, double expected)
        {
            double actual = _hw2.CountsAB(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(7, 4, "I")]
        [TestCase(-7, 4, "II")]
        [TestCase(-7, -4, "III")]
        [TestCase(7, -4, "IV")]
        public void FindQuarterTest(double x, double y, string expected)
        {
            string actual = _hw2.FindQuater(x, y);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(7, 4, 8, "4,7,8")]
        [TestCase(8, 4, 7, "4,7,8")]
        [TestCase(7, 8, 4, "4,7,8")]
        public void CompareTest(double a, double b, double c, string expected)
        {
            string actual = _hw2.Compare(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, -3, -4, "Ответ x1=-1 x2=4")]
        public void SolutionOfAQuadraticEquationTest(double a, double b, double c, string expected)
        {
            string actual = _hw2.SolutionOfAQuadraticEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        public void SolutionOfAQuadraticEquationNegativeTest(double a, double b, double c, string expected)
        {
            Assert.Throws(typeof(DivideByZeroException), () => _hw2.SolutionOfAQuadraticEquation(a, b, c));
        }

        [TestCase(11, "Результат: одинадцать")]
        [TestCase(110, "Результат: Число не принадлежит диапазону от 10 до 99")]
        [TestCase(1, "Результат: Число не принадлежит диапазону от 10 до 99")]
        public void ConvertToLettersTest(int a, string expected)
        {
            string actual = _hw2.ConvertToLetters(a);
            Assert.AreEqual(expected, actual);
        }

    }
}