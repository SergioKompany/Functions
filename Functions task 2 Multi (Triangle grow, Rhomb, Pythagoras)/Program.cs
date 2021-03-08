using System;

namespace Functions_task_2_Multi__Triangle_grow__Rhomb__Pythagoras_
{
    class Program
    {
        static void TriangleGrow ()
        {
            Console.WriteLine("This is a growing Triangle builder.\n"); 
            Console.WriteLine("Select a symbol:");
            string symbol = Console.ReadLine();
            Console.WriteLine("Select a length of a growing triangle:");
            int Length = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int y = 1;
            while (y <= Length)
            {
                int x = 1;
                while (x <= y)
                {
                    Console.Write(symbol);
                    x++;
                }
                y++;
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Rhomb ()
        {
            Console.WriteLine("This is a Rhomb builder.\n");
            Console.WriteLine("Select a symbol:");
            string symbol = Console.ReadLine();
            Console.WriteLine("Select the diameter of a rhomb (>2):");
            int diameter = int.Parse(Console.ReadLine());
            int result = (diameter % 2);
            if (diameter < 3)
            {
                Console.WriteLine("This rhomb cannot be built");
            }
            else if (result == 1)
            {
                Console.WriteLine("This rhomb is odd");
                int contrdiamfall = (diameter - 1) / 2;
                int y = 1;
                for (; y <= diameter; y += 2)
                {
                    int z = contrdiamfall;
                    for (; z > 0; z--)
                    {
                        Console.Write(" ");
                    }
                    contrdiamfall--;
                    for (int x = 1; x <= y; x++)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }
                int contrdiammax = (diameter - 1) / 2;
                for (int u = diameter - 2; u >= 1; u -= 2)
                {
                    int contrdiamgrow = contrdiammax + 1 - (u + 1) / 2;
                    int c = contrdiammax - contrdiamgrow;
                    for (; c < contrdiammax; c++)
                    {
                        Console.Write(" ");
                    }
                    contrdiamgrow++;
                    for (int x = u; x >= 1; x--)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }
            }
            else if (result == 0)
            {
                Console.WriteLine("This rhomb is even");
                int contrdiam = (diameter / 2) - 1;
                int y = 2;
                for (; y <= diameter; y += 2)
                {
                    int z = contrdiam;
                    for (; z > 0; z--)
                    {
                        Console.Write(" ");
                    }
                    contrdiam--;
                    for (int x = 1; x <= y; x++)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }
                int contrdiametermax = diameter / 2 - 1;
                int u = diameter;
                int contrdiameter = diameter / 2 - u / 2;
                for (; u >= 2; u -= 2)
                {
                    int z = contrdiametermax - contrdiameter;
                    for (; z < contrdiametermax; z++)
                    {
                        Console.Write(" ");
                    }
                    contrdiameter++;
                    for (int x = u; x > 0; x--)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
        static void spaceY(int digYmax)
        {
            int pls = digYmax;
            for (; pls > 0; pls--)
            {
                Console.Write("-");
            }
        }
        static void spaceX(int HorFst, int HorLast, int digitmax)
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
        static void Pythagoras ()
        {
            Console.WriteLine("This is a Dynamic Pythagoras Table builder.\n");
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
            spaceY(digYmax);
            Console.Write("+");
            spaceX(HorFst, HorLast, digitmax);
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
            spaceY(digYmax);
            Console.Write("+");
            spaceX(HorFst, HorLast, digitmax);
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
            spaceX(HorFst, HorLast, digitmax);
            Console.Write("+");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            TriangleGrow();
            Rhomb();
            Pythagoras();
            Console.ReadLine();
        }
    }
}
