using System;

namespace Recursion_task_3__Prime_or_Composite_number_
{
    class Program
    {
        static bool PrimeCalc (ulong i, ulong n, double SquareRoot)
        {
            i++;
            ulong reminder = (n % i);
            if (reminder == 0 && n != i)
            {
                Console.WriteLine("Divided by " + i + " reminder is " + reminder);
                return true;
            }
            else if (i < SquareRoot && reminder != 0)
            {
                Console.WriteLine("Divided by " + i + " reminder is " + reminder);
                return PrimeCalc(i, n, SquareRoot);
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a natural number (more than 1) to check if it is Prime or Composite:");
                    ulong n = ulong.Parse(Console.ReadLine());
                    if (n == 0 || n==1)
                    {
                        Console.WriteLine("The number must be more than 1");
                    }
                    else if (n > 1)
                    {
                        Console.WriteLine("Let's use a Trial division algorithm.");
                        double SquareRoot = Math.Sqrt(n);
                        Console.WriteLine("Square root of " + n + " is " + SquareRoot);
                        ulong i = 1;
                        bool result = PrimeCalc(i, n, SquareRoot);
                        if (result == true)
                        {
                            Console.WriteLine("This number is composite.");
                        }
                        else if (result == false)
                        {
                            Console.WriteLine("This number is prime.");
                        }
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("You have put not a natural or very long number!");
                }
                Console.Write("--------------------------------------------------------------------------\n");
                Console.WriteLine();
            }
        }
    }
}
