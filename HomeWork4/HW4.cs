using System;

namespace HomeWork4
{
    public class HW4
    {
        public void SolveTask1()
        {
            int[] array = CreateArray();
            int minElement = SearchesForTheMinElementOfAnArray(array);
            Console.WriteLine();
            Console.WriteLine(minElement);
        }
        public void SolveTask2()
        {
            int[] array = CreateArray();
            int maxElement = SearchesForTheMaxElementOfAnArray(array);
            Console.WriteLine();
            Console.WriteLine(maxElement);
        }
        public void SolveTask3()
        {
            int[] array = CreateArray();
            int IndexMinElement = SearchesForTheMinIndexElementOfAnArray(array);
            Console.WriteLine();
            Console.WriteLine(IndexMinElement);
        }
        public void SolveTask4()
        {
            int[] array = CreateArray();
            int IndexMaxElement = SearchesForTheMaxIndexElementOfAnArray(array);
            Console.WriteLine();
            Console.WriteLine(IndexMaxElement);
        }
        public void SolveTask5()
        {
            int[] array = CreateArray();
            int SumElement = CountsTheSumOfTheElementsOfAnArrayatAnOddIndex(array);
            Console.WriteLine();
            Console.WriteLine(SumElement);
        }
        public void SolveTask6()
        {
            int[] array = CreateArray();
            array = Revers(array);
            Console.WriteLine();
            Console.WriteLine(array);

        }
        public void SolveTask7()
        {
            int[] array = CreateArray();
            int countOfOddElement = CountsTheNumberOfOddElements(array);
            Console.WriteLine();
            Console.WriteLine(countOfOddElement);

        }
        public void SolveTask8()
        {
            int[] array = CreateArray();
            Console.WriteLine();
            SwapsHalvesOfAnArray(array);
        }
        public void SolveTask9()
        {
            int[] array = CreateArray();
            Console.WriteLine();
            BubbleSorth(array);

        }
        public void SolveTask10()
        {
            int[] array = CreateArray();
            Console.WriteLine();
            SortingWithInserts(array);

        }
        public int[] CreateArray()
        {
            Random random = new Random();

            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");

            }
            return array;
        }

        public int SearchesForTheMinElementOfAnArray(int[] array)
        {
            int minItem = array[0];
            if(array.Length == 0)
            {
                throw new IndexOutOfRangeException("ну как так-то");
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (minItem > array[i])
                {
                    minItem = array[i];
                }
            }

            return minItem;
        }
        public int SearchesForTheMaxElementOfAnArray(int[] array)
        {
            int maxItem = array[0];
            if (array.Length == 0)
            {
                throw new IndexOutOfRangeException("ну как так-то");
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (maxItem < array[i])
                {
                    maxItem = array[i];
                }
            }
            return maxItem;
        }
        public int SearchesForTheMinIndexElementOfAnArray(int[] array)
        {
            int minIndex = 0;
            int minItem3 = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (minItem3 > array[i])
                {
                    minItem3 = array[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }
        public int SearchesForTheMaxIndexElementOfAnArray(int[] array)
        {
            int maxIndex = 0;
            int maxItem = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (maxItem < array[i])
                {
                    maxItem = array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        public int CountsTheSumOfTheElementsOfAnArrayatAnOddIndex(int[] array)
        {
            int sumElementsOfNecetIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sumElementsOfNecetIndex += array[i];
                }
            }
            return sumElementsOfNecetIndex;
        }
        public int[] Revers(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = tmp;
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            return array;
        }
        public int CountsTheNumberOfOddElements(int[] array)
        {
            int sumElementsOfNecet = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sumElementsOfNecet += 1;
                }
            }
            return sumElementsOfNecet;
        }
        public int[] SwapsHalvesOfAnArray(int[] array)
        {
            int j1 = array.Length / 2;
            int tmpOddArray = 0;
            int tmpForEhth = 0;

            if (array.Length % 2 != 0)
            {
                tmpOddArray = 1;
            }

            for (int i = 0; i < j1; i++)
            {
                tmpForEhth = array[i];
                array[i] = array[i + j1 + tmpOddArray];
                array[i + j1 + tmpOddArray] = tmpForEhth;
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            return array;
        }

        public int[] BubbleSorth(int[] array)
        {
            int tmpSortBubble = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j + 1] < array[j])
                    {
                        tmpSortBubble = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = tmpSortBubble;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            return array;
        }

        public int[] SortingWithInserts(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int tmp = array[i];
                int j = i;
                while (j > 0 && tmp > array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = tmp;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            return array;
        }

        public int GetNumberForUser(string messag)
        {
            Console.WriteLine(messag);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
    }
}
