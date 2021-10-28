using System;

namespace HomeWork2
{
    public class HW2
    {
        public void SolveTask1()
        {
            double a = GetNumberForUser("Введите число а");
            double b = GetNumberForUser("Введите число b");
            double result = CountsAB(a, b);
            Console.WriteLine(result);

        }

        public void SolveTask2()
        {
            int x = GetNumberForUser("Введите x");
            int y = GetNumberForUser("Введите y");

            string result = FindQuater(x, y);
            Console.WriteLine(result);

        }
        public void SolveTask3()
        {
            int a = GetNumberForUser("Введите число а");
            int b = GetNumberForUser("Введите число b");
            int c = GetNumberForUser("Введите число c");
            string result = Compare(a, b, c);
            Console.WriteLine(result);

        }
        public void SolveTask4()
        {
            double a = GetNumberForUser("Введите число а");
            double b = GetNumberForUser("Введите число b");
            double c = GetNumberForUser("Введите число c");
            string result = CountDiscriminant(a, b, c);
            Console.WriteLine(result);
        }

        public void SolveTask5()
        {
            int number = GetNumberForUser("Введите число");
            string result = ConvertToLetters(number);
            Console.WriteLine(result);
        }

        public int GetNumberForUser(string messag)
        {
            Console.WriteLine(messag);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public double CountsAB(double a, double b)
        {
            double result;
            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }
            return result;
        }
        public string FindQuater(double X, double Y)
        {
            string result = "";
            if (X > 0 && Y > 0)
            {
                result = "I";


            }
            else if (X < 0 && Y > 0)
            {
                result = "II";
            }
            else if (X < 0 && Y < 0)
            {
                result = "III";
            }
            else
            {
                result = "IV";
            }
            if (X == 0 || Y == 0)
            {
                result = "Точка лежит на одной из координатных прямых";
            }
            return result;
        }
        public string Compare(double a, double b, double c)
        {
            string result = "";
            if (a <= b && b <= c)
            {

                result = $"{a},{b},{c}";
            }
            else if (b <= a && a <= c)
            {
                result = $"{b},{a},{c}";
            }
            else if (c <= a && a <= b)
            {
                result = $"{c},{a},{b}";
            }
            else if (a <= c && c <= b)
            {
                result = $"{a},{c},{b}";
            }
            else if (b <= c && c <= a)
            {
                result = $"{b},{c},{a}";
            }
            else if (c <= b && b <= a)
            {
                result = $"{c},{b},{a}";
            }
            return result;
        }
        public string SolutionOfAQuadraticEquation(double a, double b, double c)
        {
            string result = "";
            double discriminant = Math.Pow(b, 2) - 4 * (a) * (c);
            double x1 = ((-1 * (b)) - Math.Sqrt(discriminant)) / (2 * (a));
            double x2 = ((-1 * (b)) + Math.Sqrt(discriminant)) / (2 * (a));
            if (double.IsInfinity(x1) || double.IsInfinity(x2))
            {
                throw new DivideByZeroException("a не может быть  нулем");
            }
            if (double.IsNaN(x2) || double.IsNaN(x1))
            {

                throw new ArgumentException("Дискриминант отрицательный");
            }
            if (discriminant > 0)
            {
                result = $"Ответ x1={x1} x2={x2}";
            }

            else if (discriminant == 0)
            {
                result = $"Ответ x1={x1} x2={x2}";
            }
            return result;


        }
        public string CountDiscriminant(double a, double b, double c)
        {
            string result = "";
            double discriminant = Math.Pow(b, 2) - 4 * (a) * (c);
            double x1 = ((-1 * (b)) - Math.Sqrt(discriminant)) / (2 * (a));
            double x2 = ((-1 * (b)) + Math.Sqrt(discriminant)) / (2 * (a));
            if (discriminant > 0)
            {
                result = $"Ответ x1={x1} x2={x2}";
            }
            else if (discriminant < 0)
            {
                result = "Решений нет";
            }
            else if (discriminant == 0)
            {
                result = $"Ответ x1={x1} x2={x2}";
            }
            return result;
        }
        public string ConvertToLetters(int a)
        {
            string fromTenToNineteen = "";
            string result = "";
            fromTenToNineteen = a switch
            {
                10 => "десять",
                11 => "одинадцать",
                12 => "двенадцать",
                13 => "тринадцать",
                14 => "Четырнадцать",
                15 => "Пятнадцать",
                16 => "Шестнадцать",
                17 => "Семнадцать",
                18 => "Восемнадцать",
                19 => "Девятнадцать",
                _ => "",
            };

            int ten = a / 10;
            int one = a % 10;
            string tens = "";
            string ones = "";
            tens = ten switch
            {
                2 => "Двадцать",
                3 => "Тридцать",
                4 => "Сорок",
                5 => "Пятьдесят",
                6 => "Шестьдесят",
                7 => "Семьдесят",
                8 => "Восемдесят",
                9 => "Девяносто",
                _ => "",
            };
            ones = one switch
            {
                1 => "один",
                2 => "два",
                3 => "три",
                4 => "четыре",
                5 => "пять",
                6 => "шесть",
                7 => "семь",
                8 => "восемь",
                9 => "девять",
                _ => "",
            };
            if (a < 20 && a > 9)
            {
                result = $"Результат: " + fromTenToNineteen;
            }
            else if (a < 10 || a > 99)
            {
                result = "Результат: Число не принадлежит диапазону от 10 до 99";
            }
            else if (a > 19 && a < 100)
            {
                result = $"Результат: " + tens + " " + ones;
            }
            return result;
        }
    }
       
    
}
