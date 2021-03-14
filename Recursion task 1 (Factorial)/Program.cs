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
                Console.WriteLine("Enter a natural number to count a factorial (n!):");
                ulong n = ulong.Parse(Console.ReadLine());
                if (n == 0)
                {
                    Console.WriteLine("The factorial 0! = 1");
                }
                else if (n > 0)
                {
                    Console.WriteLine("The factorial " + n + "! = " + Factorial(n));
                }
                else
                {
                    Console.WriteLine("You have put not a natural number!");
                }
                Console.Write("-------------------------------------------------\n");
                Console.WriteLine();
            }
        }
    }
}
