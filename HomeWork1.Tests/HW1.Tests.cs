using NUnit.Framework;
using System;

namespace HomeWork1.Tests
{
    public class Tests
    {
        private HW1 _hw1;
        [SetUp]
        public void Setup()
        {
            _hw1 = new HW1();
        }

        [TestCase(5,9, 26.5)]
        public void VariablesCulcFormulaTest(int a, int b, double expected)
        {
            double actual = _hw1.VariablesCulcFormula(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(20, 4, 5)]
        [TestCase(15, 4, 3.75)]
        public void DivideNumberswithoutRemainderTest(double a, double b, double expected)
        {
            double actual = _hw1.DivideNumberswithoutRemainder(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(21, 4, 1)]
        public void DivideNumberswithRemainderTest(double a, double b, double expected)
        {
            double actual = _hw1.DivideNumberswithRemainder(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(4, 5, 3, -0.5)]
        public void LinearEquationSolutionTest (double a, double b, double c, double expected)
        {
            double actual = _hw1.LinearEquationSolution(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        public void LinearEquationSolutionNegativeTest(double a, double b, double c, double expected)
        {
            Assert.Throws(typeof(DivideByZeroException), () => _hw1.LinearEquationSolution(a, b, c));
        }
        [TestCase(8, 12, 6, 4, -0.5)]
        public void EquationOfAStraightLineTest(double x1, double x2, double y1, double y2, double expected)
        {
            double actual = _hw1.EquationOfAStraightLine(x1, x2, y1, y2);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 14, 5, 9)]
        public void FindFreeMemberTest(double x2, double y2, double a, double expected)
        {
            double actual = _hw1.FindFreeMember(x2, y2, a);
            Assert.AreEqual(expected, actual);
        }
    }
}