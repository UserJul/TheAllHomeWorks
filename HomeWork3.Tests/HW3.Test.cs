using NUnit.Framework;
using System;

namespace HomeWork3.Tests
{
    public class Tests
    {
        private HW3 _hw3;
        [SetUp]
        public void Setup()
        {
            _hw3 = new HW3();
        }

        [TestCase(2, 2, 4)]
        public void RaisesTest(int a, int b, int expected)
        {
            double actual = _hw3.Raises(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1000, "0 1000 ")]
        [TestCase(-1000, "0 1000 ")]
        public void DisplayTheNumberDivisibleByATest(int a, string expected)
        {
            string actual = _hw3.DisplayTheNumberDivisibleByA(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0, "�� ���� ������ ������")]
        public void DisplayTheNumberDivisibleByANegativeTest(int a, string expected)
        {
            Assert.Throws(typeof(DivideByZeroException), () => _hw3.DisplayTheNumberDivisibleByA(a));
        }
        [TestCase(12, 3)]
        public void LookingForValueTest(int a, int expected)
        {
            int actual = _hw3.LookingForValue(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(12, "6")]
        public void SearchesForTheGreatestCommonFactorTest(int a, string expected)
        {
            string actual = _hw3.SearchesForTheGreatestCommonFactor(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0, "�� ���� ������ ������")]
        public void SearchesForTheGreatestCommonFactorNegativeTest(int a, string expected)
        {
            Assert.Throws(typeof(DivideByZeroException), () => _hw3.DisplayTheNumberDivisibleByA(a));
        }
        [TestCase(7, 21, "42")]
        public void FindSummeryOfNumbersTest(int a, int b, string expected)
        {
            string actual = _hw3.FindSummeryOfNumbers(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2, "1")]
        public void FindsTheNumberOfAFibbanachiNumberTest(int valueN, string expected)
        {
            string actual = _hw3.FindsTheNumberOfAFibbanachiNumber(valueN);
            Assert.AreEqual(expected, actual);
        }

        public void FindsTheNumberOfAFibbanachiNumberNegativeTest(int valueN, string expected)
        {
            Assert.Throws(typeof(DivideByZeroException), () => _hw3.FindsTheNumberOfAFibbanachiNumber(valueN));
        }
        [TestCase(4, "3")]
        public void FindsTheNumberOfAFibbanachiNumber(int n, string expected)
        {
            string actual = _hw3.FindsTheNumberOfAFibbanachiNumber(n);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(-4, " ")]
        public void FindsTheNumberOfAFibbanachiNegativeNumberTest(int n, string expected)
        {
            Assert.Throws(typeof(DivideByZeroException), () => _hw3.FindsTheNumberOfAFibbanachiNumber(n));
        }
        [TestCase(2, 12, "2")]
        public void SearchesForNODViaEuclidTheoremTest(int a, int b, string expected)
        {
            string actual = _hw3.SearchesForNODViaEuclidTheorem(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}