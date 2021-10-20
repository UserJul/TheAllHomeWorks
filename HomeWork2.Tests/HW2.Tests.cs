using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWork2.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private HW2 _hw2;
        public void Setup()
        {
            _hw2 = new HW2();
        } 
        [TestMethod]
         public void CountsABTest(double a, double b, double expected)
        {
            double actual = _hw2.CountsAB(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
