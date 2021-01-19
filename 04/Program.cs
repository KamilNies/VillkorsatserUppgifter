using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Sortera 3 flyttal i fallande ordning genom att använda nästlade if */
            Console.Write("Enter first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int third = int.Parse(Console.ReadLine());
            if (first > second && third < first)
            {
                if (first > third)
                {
                    if (second > third)
                    {

                    }
                    else
                    {
                        int temp = second;
                        second = third;
                        third = temp;
                    }
                }
            }
            else if (second > first && third < second)
            {
                if (second > third)
                {
                    if (first > third)
                    {
                        int temp = second;
                        second = first;
                        first = temp;
                    }
                    else
                    {
                        int temp = second;
                        second = third;
                        third = first;
                        first = temp;
                    }
                }
            }
            else
            {
                if (third > second)
                {
                    if (first > second)
                    {
                        int temp = third;
                        third = second;
                        second = first;
                        first = temp;
                    }
                    else
                    {
                        int temp = third;
                        third = first;
                        first = temp;
                    }
                }
            }
            Console.WriteLine("{0} > {1} > {2}", first, second, third);
            Console.ReadKey();
        }
    }
}
