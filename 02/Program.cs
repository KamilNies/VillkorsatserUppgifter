using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Skriv ett program som visar tecknet (+ eller -) för produkten av tre
            flyttal utan att utföra multiplikationen. Använd en sekvens av ifsatser */
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 * num2 * num3 > 0)
            {
                Console.WriteLine("The product is positive");
            }
            else if (num1 * num2 * num3 < 0)
            {
                Console.WriteLine("The product is negative");
            }
            else
            {
                Console.WriteLine("The product is neither positive nor negative");
            }
            Console.ReadKey();
        }
    }
}
