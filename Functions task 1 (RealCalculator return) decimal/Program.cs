using System;

namespace Functions_task_1__RealCalculator_return__decimal
{
    class Program
    {
        static decimal Sum (decimal a, decimal b)
        {
            decimal sum = a + b;
            return sum;
        }
        static decimal Difer (decimal a, decimal b)
        {
            decimal difer = a - b;
            return difer;
        }
        static decimal Prod (decimal a, decimal b)
        {
            decimal prod = a * b;
            return prod;
        }
        static decimal Part (decimal a, decimal b)
        {
            decimal part = a / b;
            return part;
        }
        static decimal RealCalc()
        {
            Console.WriteLine("Enter 1st number:");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter an operator (+ - * /):");
            string oper = Console.ReadLine();
            Console.WriteLine("Enter 2d number:");
            decimal b = decimal.Parse(Console.ReadLine());
            decimal result = Decimal.Zero;
            switch (oper)
            {
                case "+":
                    result = Sum (a, b);
                    break;
                case "-":
                    result = Difer (a, b);
                    break;
                case "*":
                    result = Prod (a, b);
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("It cannot be divided by zero. Be attentive!");
                    }
                    else
                    {
                        result = Part(a, b);
                    }
                    break;
                default:
                    Console.WriteLine("You have made a mistake. Choose correct operator!");
                    break;
            }
            return result;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Result is: " + RealCalc ());
                Console.WriteLine();
                Console.WriteLine("----------------------------");
            }
        }
    }
}
