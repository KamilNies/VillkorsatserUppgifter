using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Skriv en if sats som jämför två heltalsvariabler och byter deras
            värden om den första är större än den andra */

            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                int temp = num2;
                num2 = num1;
                num1 = temp;
            }
            Console.WriteLine("{0} is greater than {1}", num2, num1);
            Console.ReadKey();
        }
    }
}
