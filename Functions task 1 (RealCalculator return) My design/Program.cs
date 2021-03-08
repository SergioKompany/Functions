using System;

namespace Functions_task_1__RealCalculator_return__My_design
{
    class Program
    {
        static double Sum(double a, double b)
        {
            double sum = a + b;
            return sum;
        }
        static double Difer(double a, double b)
        {
            double difer = a - b;
            return difer;
        }
        static double Prod(double a, double b)
        {
            double prod = a * b;
            return prod;
        }
        static double Part(double a, double b)
        {
            double part = a / b;
            return part;
        }
        static double RealCalc()
        {
            Console.WriteLine("Enter 1st number:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter an operator (+ - * /):");
            string oper = Console.ReadLine();
            Console.WriteLine("Enter 2d number:");
            double b = double.Parse(Console.ReadLine());
            double result = 0;
            switch (oper)
            {
                case "+":
                    result = Sum(a, b);
                    break;
                case "-":
                    result = Difer(a, b);
                    break;
                case "*":
                    result = Prod(a, b);
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("It cannot be divided by zero. Be attentive!");
                        result = double.PositiveInfinity;
                    }
                    else
                    {
                        result = Part(a, b);
                    }
                    break;
                default:
                    Console.WriteLine("You have made a mistake. Choose correct operator!");
                    result = Double.NaN;
                    break;
            }
            return result;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Result is: " + RealCalc());
                Console.WriteLine();
                Console.WriteLine("----------------------------");
            }
        }
    }
}
