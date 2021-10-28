using NUnit.Framework;

namespace HomeWork5.Tests
{
    public class Tests
    {
        private HW5 _hw5;
        [SetUp]
        public void Setup()
        {
            _hw5 = new HW5();
        }

        [TestCase(1, 1)]
        public void FindForTheMinElementTest(int mockNumber, int expected)
        {
            int[,] doubleArray = _hw5.GetMock(mockNumber);
            int actual = _hw5.FindForTheMinElement(doubleArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 9)]
        public void FindForTheMaxElementTest(int mockNumber, int expected)
        {
            int[,] doubleArray = _hw5.GetMock(mockNumber);
            int actual = _hw5.FindForTheMaxElement(doubleArray);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, new int[] { 0, 0 })]
        public void FindForTheMinIndexElemenTest(int mockNumber, int[] expected)
        {
            int[,] doubleArray = _hw5.GetMock(mockNumber);
            int[] actual = _hw5.FindForTheMinIndexElement(doubleArray);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, new int[] { 2, 2 })]
        public void FindForTheMaxIndexElementTest(int mockNumber, int[] expected)
        {
            int[,] doubleArray = _hw5.GetMock(mockNumber);
            int[] actual = _hw5.FindForTheMaxIndexElement(doubleArray);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 1)]
        public void FindsTheNumberOfElementsMoreThanItsNeighborsTest(int mockNumber, int expected)
        {
            int[,] doubleArray = _hw5.GetMock(mockNumber);
            int actual = _hw5.FindsTheNumberOfElementsMoreThanItsNeighbors(doubleArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2)]
        public void ReflectsAnArrayTest(int mockNumber, int mockNumber2)
        {
            int[,] actual = _hw5.GetMock(mockNumber);
            int[,] expected = _hw5.GetMock(mockNumber2);

            _hw5.ReflectsAnArray(actual);

            Assert.AreEqual(expected, actual);
        }

    }
}