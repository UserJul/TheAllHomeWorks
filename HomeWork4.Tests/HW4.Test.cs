using NUnit.Framework;
using System;

namespace HomeWork4.Tests
{
    public class Tests
    {
        private HW4 _hw4;
        [SetUp]
        public void Setup()
        {
            _hw4 = new HW4();
        }

        [TestCase(new int[] { 1, 2, 3 }, 1)]
        [TestCase(new int[] { 0 }, 0)]
        public void SearchesForTheMinElementOfAnArrayTest(int[] array, int expected)
        {
            int actual = _hw4.SearchesForTheMinElementOfAnArray(array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { }, "ну как так - то")]
        public void SearchesForTheMinElementOfAnArrayNegativeTest(int[] array, string expected)
        {
            Assert.Throws(typeof(IndexOutOfRangeException), () => _hw4.SearchesForTheMinElementOfAnArray(array));
        }

        [TestCase(new int[] { 1, 2, 3 }, 0)]
        [TestCase(new int[] { 0 }, 0)]
        public void SearchesForTheMinIndexElementOfAnArrayTest(int[] array, int expected)
        {
            int actual = _hw4.SearchesForTheMinIndexElementOfAnArray(array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { }, "ну как так - то")]
        public void SearchesForTheMinIndexElementOfAnArrayNegativeTest(int[] array, string expected)
        {
            Assert.Throws(typeof(IndexOutOfRangeException), () => _hw4.SearchesForTheMinIndexElementOfAnArray(array));
        }

        [TestCase(new int[] { 1, 2, 3 }, 2)]
        [TestCase(new int[] { 0 }, 0)]
        public void SearchesForTheMaxIndexElementOfAnArrayTest(int[] array, int expected)
        {
            int actual = _hw4.SearchesForTheMaxIndexElementOfAnArray(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, "ну как так - то")]
        public void SearchesForTheMaxIndexElementOfAnArrayNegativeTest(int[] array, string expected)
        {
            Assert.Throws(typeof(IndexOutOfRangeException), () => _hw4.SearchesForTheMaxIndexElementOfAnArray(array));
        }

        [TestCase(new int[] { 1, 2, 3 }, 2)]
        [TestCase(new int[] { 1, 2, 3, 4}, 6)]
        [TestCase(new int[] { 0 }, 0)]
        public void CountsTheSumOfTheElementsOfAnArrayatAnOddIndexTest(int[] array, int expected)
        {
            int actual = _hw4.CountsTheSumOfTheElementsOfAnArrayatAnOddIndex(array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        public void ReversTest(int[] array, int[] expected)
        {
            int[] actual = _hw4.Revers(array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, 2)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 2)]
        [TestCase(new int[] { 0 }, 0)]
        public void CountsTheNumberOfOddElementsTest(int[] array, int expected)
        {
            int actual = _hw4.CountsTheNumberOfOddElements(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4}, new int[] { 3, 4, 1, 2 })]
        [TestCase(new int[] { 1, 2, 3}, new int[] { 3, 2, 1 })]
        public void SwapsHalvesOfAnArrayTest(int[] array, int[] expected)
        {
            int[] actual = _hw4.SwapsHalvesOfAnArray(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 7, 2, 5 }, new int[] { 2, 5, 7 })]
        public void BubbleSorthTest(int[] array, int[] expected)
        {
            int[] actual = _hw4.BubbleSorth(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 4, 3, 2, 1 })]
        [TestCase(new int[] { 7, 2, 5 }, new int[] { 7, 5, 2 })]
        public void SortingWithInsertsTest(int[] array, int[] expected)
        {
            int[] actual = _hw4.SortingWithInserts(array);
            Assert.AreEqual(expected, actual);
        }
    }
}