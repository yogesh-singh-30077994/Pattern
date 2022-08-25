using System;

class Pattern
{
    static void printSpace(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(" ");
        }
    }

    static void printStars(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write("*");
        }
    }

    static void Main()
    {
        int n;

        Console.Write("Level: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"You Entered: {n}");

        Console.WriteLine();

        Console.WriteLine("Pattern#1");
        for (int i = 0; i < n; i++)
        {
            printStars(i + 1);
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("Pattern#2");
        for (int i = 0; i < n; i++)
        {
            printSpace(n - i - 1);
            printStars(i + 1);
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("Pattern#3");
        for (int i = 0; i < n; i++)
        {
            printSpace(i);
            printStars(n - i);
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("Pattern#4");
        for (int i = 0; i < n; i++)
        {
            printSpace(n - i - 1);
            printStars(2 * (i + 1) - 1);
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("Pattern#5");
        for (int i = 0; i < n; i++)
        {
            printSpace(i);
            printStars(2 * (n - i) - 1);
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("Pattern#6");
        for (int i = 0, j = 0; i < n; ++i)
        {
            if (i < n / 2)
            {
                printSpace(n / 2 - i);
                printStars(2 * (i + 1) - 1);
            } 
            else
            {
                printSpace(i - n / 2);
                printStars(2 * (n / 2 - j + 1) - 1);
                ++j;
            }
            Console.WriteLine();
        }
    }
}
