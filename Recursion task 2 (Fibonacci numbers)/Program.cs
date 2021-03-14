using System;

namespace Recursion_task_2__Fibonacci_numbers_
{
    class Program
    {
        static void Fibonacci (int a, int b, int n, int x)
        {
            if (x < n)
            {
                Console.Write(a + " ");
                x++;
                int Sum = a + b;
                a = b;
                b = Sum;
                Fibonacci(a, b, n, x);
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number of members from Fibonacci sequence you want to see:");
                int n = int.Parse(Console.ReadLine());
                if (n > 0)
                {
                    int x = 0;
                    int a = 0;
                    int b = 1;
                    Console.WriteLine("The Fibonacci numbers are:\n");
                    Fibonacci(a, b, n, x);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("You have put not a natural number!");
                }
                Console.Write("------------------------------------------------------------------\n");
                Console.WriteLine();
            }
        }
    }
}
