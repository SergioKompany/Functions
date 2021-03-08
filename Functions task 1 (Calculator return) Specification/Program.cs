using System;

namespace Functions_task_1__Calculator_return__Specification
{
    class Program
    {
        static double Sum (double a, double b)
        {
            double sum = a + b;
            return sum;
        }
        static double Difer (double a, double b)
        {
            double difer = a - b;
            return difer;
        }
        static double Prod (double a, double b)
        {
            double prod = a * b;
            return prod;
        }
        static double Part (double a, double b)
        {
            double part = a / b;
            return part;
        }
        static double Calculator (double a, string oper, double b)
        {
            double res = 0;
            switch (oper)
            {
                case "+":
                    res = Sum (a, b);
                    break;
                case "-":
                    res = Difer (a, b);
                    break;
                case "*":
                    res = Prod (a, b);
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("It cannot be divided by zero. Be attentive!");
                        res = double.PositiveInfinity;
                    }
                    else
                    {
                        res = Part (a, b);
                    }
                    break;
                default:
                    Console.WriteLine("You have made a mistake. Choose correct operator!");
                    res = Double.NaN;
                    break;
            }
            return res;
        }
            static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter 1st number:");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter an operator (+ - * /):");
                string oper = Console.ReadLine();
                Console.WriteLine("Enter 2d number:");
                double b = double.Parse(Console.ReadLine());
                double result = Calculator (a, oper, b);
                Console.WriteLine("Result is: " + result);
                Console.WriteLine();
                Console.WriteLine("----------------------------");
            }
        }
    }
}
