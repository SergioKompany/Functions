using System;

namespace Recursion_task_2__Fibonacci_numbers_list__93_limited
{
    class Program
    {
        static void Fibonacci(ulong a, ulong b, int n, int x)
        {
            if (x <= n)
            {
                Console.WriteLine(x + ") " + a + " ");
                x++;
                ulong Sum = a + b;
                a = b;
                b = Sum;
                Fibonacci(a, b, n, x);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number of members from Fibonacci sequence you want to see (up to 93):");
                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("You have put not a natural number!");
                }
                else if (n > 93)
                {
                    Console.WriteLine("The number must be not more than 93.");
                    Console.WriteLine("This type of data (UInt64) can not show you correctly so long number!");
                }
                else if (n >= 0)
                {
                    int x = 0;
                    ulong a = 0;
                    ulong b = 1;
                    Console.WriteLine("The Fibonacci numbers are:");
                    Fibonacci(a, b, n, x);
                    Console.WriteLine();
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("You have put a number which is out of Int32 range!");
            }
            Console.ReadLine();
        }
    }
}
