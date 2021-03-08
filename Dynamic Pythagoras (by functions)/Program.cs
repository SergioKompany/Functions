using System;

namespace Dynamic_Pythagoras__by_functions_
{
    class Program
    {
        static void spaceY (int digYmax)
        {
            int pls = digYmax;
            //If you change pls to ">= 0;" here, also in "plus" and "plys"
            //you will get one extra space before vertical numbers: " 150" (instead of "150")
            //and "----" instead of "---". It is up to you!
            for (; pls > 0; pls--)
            {
                Console.Write("-");
            }
        }
        static void spaceX (int HorFst, int HorLast, int digitmax)
        {
            for (int x = HorFst; x <= HorLast; x++)
            {
                int d = 0;
                for (; d <= digitmax; d++)
                {
                    Console.Write("-");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Dynamic Pythagoras Table!\n");
            Console.WriteLine("Enter first horizontal number:");
            int HorFst = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter last horizontal number:");
            int HorLast = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first vertical number:");
            int VerFst = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter last vertical number:");
            int VerLast = int.Parse(Console.ReadLine());
            int x = HorFst;
            int y = VerFst;
            int maximum = HorLast * VerLast;
            int digit = maximum;
            int count = 0;
            for (; digit >= 1;)
            {
                digit = digit / 10;
                count++;
            }
            int digitmax = count;
            Console.WriteLine("\nThe maximum numbers' product is: " + maximum + ".");
            Console.WriteLine("It consists of " + digitmax + " digit(s).\n");
            Console.WriteLine("Let's build a Pythagoras Table using your data!");
            Console.WriteLine();
            int digVermax = VerLast;
            int countYmax = 0;
            for (; digVermax >= 1;)
            {
                digVermax = digVermax / 10;
                countYmax++;
            }
            int digYmax = countYmax;
            spaceY (digYmax);
            Console.Write("+");
            spaceX (HorFst, HorLast, digitmax);
            Console.Write("+");
            Console.WriteLine();
            int plus = digYmax;
            for (; plus > 0; plus--)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            for (x = HorFst; x <= HorLast; x++)
            {
                int digitX = x;
                int countX = 0;
                for (; digitX >= 1;)
                {
                    digitX = digitX / 10;
                    countX++;
                }
                int kontrX = digitmax - countX;
                for (; kontrX >= 0; kontrX--)
                {
                    Console.Write(" ");
                }
                Console.Write(x);
            }
            Console.Write("|");
            Console.WriteLine();
            spaceY (digYmax);
            Console.Write("+");
            spaceX (HorFst, HorLast, digitmax);
            Console.Write("+");
            Console.WriteLine();
            for (y = VerFst; y <= VerLast; y++)
            {
                int digY = y;
                int countY = 0;
                for (; digY >= 1;)
                {
                    digY = digY / 10;
                    countY++;
                }
                int digitY = countY;

                int plys = digYmax - digitY;
                for (; plys > 0; plys--)
                {
                    Console.Write(" ");
                }
                Console.Write(y + "|");
                for (x = HorFst; x <= HorLast; x++)
                {
                    int product = x * y;
                    int digitP = product;
                    int countP = 0;
                    for (; digitP >= 1;)
                    {
                        digitP = digitP / 10;
                        countP++;
                    }
                    int kontrP = digitmax - countP;
                    for (; kontrP >= 0; kontrP--)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(product);
                }
                Console.Write("|");
                Console.WriteLine();
            }
            spaceY(digYmax);
            Console.Write("+");
            spaceX (HorFst, HorLast, digitmax);
            Console.Write("+");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
