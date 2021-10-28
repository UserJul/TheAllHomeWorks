using System;

namespace HomeWork3
{
    public class HW3
    {
        public void SolveTask1()
        {
            int a = GetNumberForUser("Введите число а");
            int b = GetNumberForUser("Введите число b");
            int result = Raises(a, b);
            Console.WriteLine(result);
        }
        public void SolveTask2()
        {
            int a = GetNumberForUser("Введите число а");
            string result = DisplayTheNumberDivisibleByA(a);
            Console.WriteLine(result);
        }
        public void SolveTask3()
        {
            int a = GetNumberForUser("Введите число а");
            int count = LookingForValue(a);
            Console.WriteLine(count);
        }
        public void SolveTask4()
        {
            int a = GetNumberForUser("Введите число а");
            string nd = SearchesForTheGreatestCommonFactor(a);
            Console.WriteLine(nd);
        }

        public void SolveTask5()
        {
            Console.WriteLine("Cycles5");
            int a = GetNumberForUser("Введите число a");
            int b = GetNumberForUser("Введите число b");
            string sum = FindSummeryOfNumbers(a, b);
            Console.WriteLine(sum);
        }

        public void SolveTask6()
        {
            int valueN = GetNumberForUser("Введите число N");
            FindsTheNumberOfAFibbanachiNumber(valueN);
            string Fibonachi = FindsTheNumberOfAFibbanachiNumber(valueN);
            Console.WriteLine(Fibonachi);
        }

        public void SolveTask7()
        {
            int a = GetNumberForUser("Введите число а");
            int b = GetNumberForUser("Введите число b");
            string nod = SearchesForNODViaEuclidTheorem(a, b);
            Console.WriteLine(nod);
        }

        public void SolveTask8()
        {
            int valueN = GetNumberForUser("Введите число N");
            int mid = CountsByHalfDivision(valueN);
            Console.WriteLine(mid);

        }
        public void SolveTask9()
        {
            int n = GetNumberForUser("Введите число N");
            int countOddnumber = SearchesForTheNumberOfOddDigits(n);
            Console.WriteLine(countOddnumber);

        }
        public void SolveTask10()
        {
            int n = GetNumberForUser("Введите число N");
            int num = ReversNumber(n);
            Console.WriteLine(num);
        }
        public void SolveTask11()
        {
            int n = GetNumberForUser("Введите число N");
            int[] sum = FindSumChetMoreThenSumNechet(n);

        }
        public void SolveTask12()
        {
            int a = GetNumberForUser("Введите число а");
            int b = GetNumberForUser("Введите число b");
            string result = LookingForTheSameNumbers(a, b);
            Console.WriteLine(result);
        }

        public int GetNumberForUser(string messag)
        {
            Console.WriteLine(messag);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public int Raises(int a, int b)
        {
            int result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }
            return result;
        }

        public string DisplayTheNumberDivisibleByA(int a)
        {

            string result = "";
            if (a == 0)
            {
                throw new DivideByZeroException("На ноль делить нельзя");
            }
            if (a < 0)
            {
                for (int i = 0; a * i >= -1000; i++)
                {
                    result += $"{(a * i) * (-1)} ";

                }
            }
            else
                for (int i = 0; a * i <= 1000; i++)
                {
                    result += $"{a * i} ";


                }
            return result;
        }
        public int LookingForValue(int a)
        {
            int amount = 0;
            for (int i = 1; i < a; i++)
            {
                if (i * i < a)
                {
                    amount++;
                }
            }
            return amount;
        }
        public string SearchesForTheGreatestCommonFactor(int a)
        {
            int nd = 1;
            string result = " ";
            if( a == 0)
            {
                throw new DivideByZeroException("На ноль делить нельзя");
            }
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    nd = i;
                    result = $"{nd}";
                }
            }
            return result;
        }

        public string FindSummeryOfNumbers(int a, int b)
        {
            int sum = 0;
            string result = "";
            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                        result = $"{sum}";
                    }
                }
            }
            else if (a > b)
            {
                for (int i = b; i <= a; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                        result = $"{sum}";
                    }
                }
            }

            return result;
        }
        public string FindsTheNumberOfAFibbanachiNumber(int valueN)
        {
            int fibonachiN = 1;
            int previous1 = 0;
            int previous2 = 1;
            string result = " ";
           if(valueN > 0)
            {
                for (int i = 1; i < valueN; i++)
                {
                    fibonachiN = previous1 + previous2;
                    previous1 = previous2;
                    previous2 = fibonachiN;
                    result = $"{fibonachiN}";
                }
            }
            else
            {
                throw new DivideByZeroException();
            }
           
            return result;
        }

        public string SearchesForNODViaEuclidTheorem(int a, int b)
        {
            int nod = 1;
            string result = "";
            int tmpEvklid = 0;
            if (a > b)
            {
                while (a != b)
                {
                    a = a - b;
                    if (a < b)
                    {
                        tmpEvklid = b;
                        b = a;
                        a = tmpEvklid;
                    }
                }
                nod = b;
                result = $"{ nod}";
            }
            else if (a < b)
            {
                while (a != b)
                {
                    b = b - a;
                    if (b < a)
                    {
                        tmpEvklid = b;
                        b = a;
                        a = tmpEvklid;
                    }
                }
                nod = b;
                result = $"{ nod}";
            }
            else
            {
                nod = a;
                result = $"{ nod}";
            }

            return result;
        }
        public int CountsByHalfDivision(int N)
        {
            int left = 0;
            int mid = 0;
            int right = N;

            while (Math.Pow(mid, 3) != N)
            {
                if (left < right)
                {
                    mid = (left + right) / 2;
                  
                    if (Math.Pow(mid, 3) > N)
                    { right = mid;
                    }
                    else if (Math.Pow(mid, 3) < N)
                    { left = mid;
                    }
                }
                else if (left > right)
                {
                    mid = left;
                    mid = (mid + right) / 2;
                }
            }
            return mid;
        }

        public int SearchesForTheNumberOfOddDigits(int n)
        {
            string result = "";
            int count = 0;
            int tmp = 0;
            while (n > 0)
            {
                tmp = n % 10;
                if (tmp % 2 != 0)
                {
                    count += 1;
                }
                n /= 10;
            }
            return count;
        }
        public int ReversNumber(int n)
        {
            int num = 0;
            while (n > 0)
            {
                num = num * 10 + n % 10;
                n = n / 10;
            }
            return num;
        }
        public string LookingForTheSameNumbers(int a, int b)
        {
            string str = " ";
            int tmp1 = Math.Abs(a);
            int tmp2 = Math.Abs(b);
            int srav = 0;
            int i = 0;
            int j = 0;
            if (a != 0 || b != 0)
            {
                while (tmp1 > 0)
                {
                    i = tmp1 % 10;
                    tmp1 = tmp1 / 10;
                    while (tmp2 > 0)
                    {
                        j = tmp2 % 10;
                        tmp2 = tmp2 / 10;
                        if (i == j)
                        {
                            srav++;

                        }

                    }
                    tmp2 = b;
                }
                if (srav != 0)
                {
                    str = "yes";
                    return str;
                }
                else
                {
                    str = "no";
                    return str;
                }
            }
            else
            {
                str = "Введеные числа равны 0";
                return str;
            }
        }
        public int[] FindSumChetMoreThenSumNechet(int n)
        {
            int sumChet = 0;
            int sumNechet = 0;
            int tmp1 = 0;
            int tmp2 = 0;
            int counter = 0;
            for (int i = 1; i <= n; i++)
            {
                tmp2 = i;
                while (tmp2 > 0)
                {
                    tmp1 = tmp2 % 10;
                    if (tmp1 % 2 == 0)
                    {
                        sumChet += tmp1;
                    }
                    else
                    {
                        sumNechet += tmp1;
                    }
                    tmp2 = tmp2 / 10;
                }
                if (sumChet > sumNechet)
                {
                    counter++;
                    sumChet = 0;
                    sumNechet = 0;
                }
                else
                {
                    sumChet = 0;
                    sumNechet = 0;
                }
            }
            int[] result = new int[counter];
            sumChet = 0;
            sumNechet = 0;
            tmp1 = 0;
            tmp2 = 0;
            for (int i = 1, k = 0; i <= n; i++)
            {
                tmp2 = i;
                while (tmp2 > 0)
                {
                    tmp1 = tmp2 % 10;
                    if (tmp1 % 2 == 0)
                    {
                        sumChet += tmp1;
                    }
                    else
                    {
                        sumNechet += tmp1;
                    }
                    tmp2 = tmp2 / 10;
                }
                if (sumChet > sumNechet)
                {
                    result[k] = i;
                    k++;
                    sumChet = 0;
                    sumNechet = 0;
                }
                else
                {
                    sumChet = 0;
                    sumNechet = 0;
                }
            }
            return result;
        }
    }
}
