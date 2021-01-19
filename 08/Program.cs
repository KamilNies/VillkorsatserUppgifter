using System;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Skriv ett program som, beroende på användarens val, läser in en int,
            double eller string variabel. Om variabeln är heltal eller flyttal, öka
            på det med 1. Om det är en sträng så lägg till en "*" på slutet.
            Programmet skall visa variabelns värde på konsolen. Använd en
            switch. */
            Console.WriteLine("Press a number to choose: ");
            Console.WriteLine("int:     1");
            Console.WriteLine("double:  2");
            Console.WriteLine("string:  3");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter an integer: ");
                    int intNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("After operation, var is set to {0}", intNum + 1);
                    break;
                case 2:
                    Console.WriteLine("Enter a double: ");
                    double doubleNum = double.Parse(Console.ReadLine());
                    Console.WriteLine("After operation, var is set to {0}", doubleNum + 1);
                    break;
                case 3:
                    Console.WriteLine("Enter a string: ");
                    string str = Console.ReadLine();
                    Console.WriteLine("After operation, var is set to {0}", str + "*");
                    break;
                default:
                    Console.WriteLine("Input not valid");
                    break;
            }
            Console.ReadKey();
        }
    }
}
