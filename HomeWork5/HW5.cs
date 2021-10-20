using System;

namespace HomeWork5
{
    public class HW5
    {
        public void SolveTask1()
        {
            int[,] doubleArray = CreatedoubleArray();
            int minElement = SearchesForTheMinElementOfAnArray(doubleArray);
            Console.WriteLine();
            Console.WriteLine(minElement);

        }
        public void SolveTask2()
        {
            int[,] doubleArray = CreatedoubleArray();
            int maxElement = SearchesForTheMaxElementOfAnArray(doubleArray);
            Console.WriteLine();
            Console.WriteLine(maxElement);
        }
        public void SolveTask3()
        {
            int[,] doubleArray = CreatedoubleArray();
            string minIndex = SearchesForTheMinIndexElementOfAnArray(doubleArray);
            Console.WriteLine();
            Console.WriteLine(minIndex);

        }
        public void SolveTask4()
        {
            int[,] doubleArray = CreatedoubleArray();
            string maxIndex = SearchesForTheMaxIndexElementOfAnArray(doubleArray);
            Console.WriteLine();
            Console.WriteLine(maxIndex);
        }

        public void SolveTask5()
        {
            int[,] doubleArray = CreatedoubleArray();
            int count = FindsTheNumberOfElementsMoreThanItsNeighbors(doubleArray);
            Console.WriteLine();
            Console.WriteLine(count);
        }
        public void SolveTask6()
        {
            int[,] doubleArray = CreatedoubleArray();
            Console.WriteLine();
            ReflectsAnArray(doubleArray);

        }
        public int[,] CreatedoubleArray()
        {
            int[,] doubleArray = new int[4, 4];

            Random random = new Random();
            for (int i = 0; i < doubleArray.GetLength(0); i++)
            {
                for (int j = 0; j < doubleArray.GetLength(1); j++)
                {
                    doubleArray[i, j] = random.Next(-100, 100);
                    Console.Write(doubleArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            return doubleArray;
        }
        public int SearchesForTheMinElementOfAnArray(int[,] array)
        {
            int minElement = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (minElement > array[i, j])
                    {
                        minElement = array[i, j];
                    }
                }
            }
            return minElement;

        }
        public int SearchesForTheMaxElementOfAnArray(int[,] array)
        {
            int maxElement = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (maxElement < array[i, j])
                    {
                        maxElement = array[i, j];
                    }
                }
            }
            return maxElement;
        }
        public string SearchesForTheMinIndexElementOfAnArray(int[,] array)
        {
            int[] indexOfMinElemen = new int[2];
            int minElement = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (minElement < array[i, j])
                    {
                        minElement = array[i, j];
                        indexOfMinElemen[0] = i;
                        indexOfMinElemen[1] = j;
                    }
                }
            }
            string result = " ";
            result = $"{indexOfMinElemen[0]}, {indexOfMinElemen[1]}";
            return result;
        }

        public string SearchesForTheMaxIndexElementOfAnArray(int[,] array)
        {
            int[] indexOfMaxElemen = new int[2];
            int maxElement = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (maxElement < array[i, j])
                    {
                        maxElement = array[i, j];
                        indexOfMaxElemen[0] = i;
                        indexOfMaxElemen[1] = j;
                    }
                }
            }
            string result = " ";
            result = $"{indexOfMaxElemen[0]}, {indexOfMaxElemen[1]}";
            return result;
        }
        public int FindsTheNumberOfElementsMoreThanItsNeighbors(int[,] array)
        {
            int countOfElements = 0;
            int line = array.GetLength(0);
            int column = array.GetLength(1);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (
                            (i == 0 || array[i, j] > array[i - 1, j]) &&
                            (i == line - 1 || array[i, j] > array[i + 1, j]) &&
                            (j == 0 || array[i, j] > array[i, j - 1]) &&
                            (j == column - 1 || array[i, j] > array[i, j + 1])
                        )

                    {
                        countOfElements++;
                    }
                }
            }
            return countOfElements;
        }

        public int[,] ReflectsAnArray(int[,] array)
        {
            int tmp = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = i + 1; j < array.GetLength(1); j++)
                {
                    tmp = array[i, j];
                    array[i, j] = array[j, i];
                    array[j, i] = tmp;
                }
            }
            Console.WriteLine();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
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
