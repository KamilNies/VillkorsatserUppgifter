using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Skriv ett program som hittar det största av tre heltal genom att
            använda nästlade if */
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("{0} is greater than {1} and {2}", num1, num2, num3);
                }
                else
                {
                    Console.WriteLine("{0} is greater than {1} and {2}", num3, num2, num1);
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine("{0} is greater than {1} and {2}", num2, num1, num3);
                }
                else
                {
                    Console.WriteLine("{0} is greater than {1} and {2}", num3, num1, num2);
                }
                
            }
            Console.ReadKey();
        }
    }
}
