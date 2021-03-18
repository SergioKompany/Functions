using System;

namespace Recursion_task_1__Factorial_
{
    class Program
    {
        static ulong Factorial (ulong n)
        {
            n--;
            if (n > 0)
            {
                return (n + 1) * Factorial(n);
            }
            return n + 1;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a natural number (up to 65) to count a factorial (n!):");
                    ulong n = ulong.Parse(Console.ReadLine());
                    if (n == 0)
                    {
                        Console.WriteLine("The factorial 0! = 1");
                    }
                    else if (n > 65)
                    {
                        Console.WriteLine("Even this type of data (UInt64) can not show you so long number!");
                    }
                    else if (n > 0)
                    {
                        Console.WriteLine("The factorial " + n + "! = " + Factorial(n));
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("You have put not a natural number!");
                }   
                Console.Write("------------------------------------------------------------\n");
                Console.WriteLine();
            }
        }
    }
}
