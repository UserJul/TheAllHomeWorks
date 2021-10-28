using System;

namespace HomeWork5
{
    public class HW5
    {
        public void SolveTask1()
        {
            int[,] doubleArray = CreatedoubleArray();
            int minElement = FindForTheMinElement(doubleArray);
            Console.WriteLine();
            Console.WriteLine(minElement);

        }
        public void SolveTask2()
        {
            int[,] doubleArray = CreatedoubleArray();
            int maxElement = FindForTheMaxElement(doubleArray);
            Console.WriteLine();
            Console.WriteLine(maxElement);
        }
        public void SolveTask3()
        {
            int[,] doubleArray = CreatedoubleArray();
            int[] minIndex = FindForTheMinIndexElement(doubleArray);
            Console.WriteLine();
            Console.WriteLine($"{minIndex[0]}, {minIndex[1]}");

        }
        public void SolveTask4()
        {
            int[,] doubleArray = CreatedoubleArray();
            int[] maxIndex = FindForTheMaxIndexElement(doubleArray);
            Console.WriteLine();
            Console.WriteLine($"{maxIndex[0]}, {maxIndex[1]}");
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
        public int FindForTheMinElement(int[,] array)
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
        public int FindForTheMaxElement(int[,] array)
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
        public int[] FindForTheMinIndexElement(int[,] array)
        {
            int minElement = array[0, 0];
            int indexI = 0;
            int indexJ = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (minElement > array[i, j])
                    {
                        minElement = array[i, j];
                        indexI = i;
                        indexJ = j;
                    }
                }
            }
            int[] result = new int[2] { indexI, indexJ };

            return result;
        }

        public int[] FindForTheMaxIndexElement(int[,] array)
        {
            int maxElement = array[0, 0];
            int indexI = 0;
            int indexJ = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (maxElement < array[i, j])
                    {
                        maxElement = array[i, j];
                        indexI = i;
                        indexJ= j;
                    }
                }
            }
            int[] tmpArray = new int[2] { indexI, indexJ };
            return tmpArray;
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
        public int[,] GetMock(int number)
        {
            int[,] result = new int[0, 0];
            switch(number)
            {
                case 1:
                    result = new int[,]
                    {
                        { 1, 2, 3},
                        {4, 5, 6},
                        {7, 8, 9}
                    };
                    break;
                case 2:
                    result = new int[,]
                    {
                        {1, 4, 7 },
                        {2, 5, 8 },
                        {3, 6, 9 }
                    };
                    break;
            }
            return result;
        }
    }
}
