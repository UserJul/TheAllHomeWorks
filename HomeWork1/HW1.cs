using System;

namespace HomeWork1
{
    public class HW1
    {
        public void SolveTask1()
        {
            int a = (int)GetNumberForUser("Введите число а");
            int b = (int)GetNumberForUser("Введите число b");
            double result = VariablesCulcFormula(a, b);
            Console.WriteLine(result);
        }
        public void SolveTask2()
        {
            string stringOne = GetStringFromUser("Введите первую строку");
            string stringTwo = GetStringFromUser("Введите вторую строку");
            string result = ReverseStrings(stringOne, stringTwo);
            Console.WriteLine($"Результат: {result}");

        }
        public void SolveTask3()
        {
            double a = GetNumberForUser("Введите число a");
            double b = GetNumberForUser("Введите число b");
            double result = DivideNumberswithoutRemainder(a, b);
            double result1 = DivideNumberswithRemainder(a, b);
            Console.WriteLine($"Результат третьей задачи: {result}, {result1}");


        }
        public void SolveTask4()
        {
            double a = GetNumberForUser("Введите число а");
            double b = GetNumberForUser("Введите число b");
            double c = GetNumberForUser("Введите число c");
            double x = LinearEquationSolution(a, b, c);
            Console.WriteLine($"x={x}");

        }
        public void SolveTask5()
        {
            int x1 = (int)GetNumberForUser("Введите значение x1");
            int x2 = (int)GetNumberForUser("Введите значение x2");
            int y1 = (int)GetNumberForUser("Введите значение y1");
            int y2 = (int)GetNumberForUser("Введите значение y2");
            double A = EquationOfAStraightLine(x1, x2, y1, y2);
            double B = FindFreeMember(y2, A, x2);
            Console.WriteLine($"Y = {A}*X + {B} ");

        }
        public double VariablesCulcFormula(int a, int b)
        {
            double result = (5 * a + b * b * 1.0)/ (b - a);
            return result;
        }

        public double GetNumberForUser(string messag)
        {
            Console.WriteLine(messag);
            double number = Convert.ToDouble(Console.ReadLine());
            return number;
        }
        public string GetStringFromUser(string message)
        {
            Console.WriteLine(message);
            string stringOne = Console.ReadLine();
            return stringOne;
        }
        public string ReverseStrings(string stringOne, string stringTwo)
        {
            string result = stringTwo + stringOne;
            return result;
        }
        public double DivideNumberswithoutRemainder(double a, double b)
        {
            double result = a / b;
            return result;

        }
        public double DivideNumberswithRemainder(double a, double b)
        {
            double result1 = a % b;
            return result1;

        }
        public double LinearEquationSolution(double a, double b, double c)
        {
            if(a ==b && a ==c && b == c)
            {
                throw new DivideByZeroException("тобi жопа");
            }
            double x = (c - b) / a;
            return x;
        }
        public double EquationOfAStraightLine(double x1, double x2, double y1, double y2)
        {
            double a = (y2 - y1) / (x2 - x1);
            if(double.IsInfinity(a) || double.IsNaN(a))
            {
                throw new DivideByZeroException("тобi жопа");
            }
            return a;
        }
        public double FindFreeMember(double x2, double y2, double a)
        {
            double b = (y2 - (a * x2));
            return b;
        }
    }
}
