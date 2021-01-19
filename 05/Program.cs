using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Skriv ett program som frågar efter en siffra. Beroende på det inmatade
            talet skriv ut namnet på siffran (på svenska) genom att använda en
            switch */
            Console.Write("Skriv in en siffra: ");
            byte siffra = byte.Parse(Console.ReadLine());
            switch (siffra)
            {
                case 0:
                    Console.WriteLine("Noll");
                    break;
                case 1:
                    Console.WriteLine("Ett");
                    break;
                case 2:
                    Console.WriteLine("Två");
                    break;
                case 3:
                    Console.WriteLine("Tre");
                    break;
                case 4:
                    Console.WriteLine("Fyra");
                    break;
                case 5:
                    Console.WriteLine("Fem");
                    break;
                case 6:
                    Console.WriteLine("Sex");
                    break;
                case 7:
                    Console.WriteLine("Sju");
                    break;
                case 8:
                    Console.WriteLine("Åtta");
                    break;
                case 9:
                    Console.WriteLine("Nio");
                    break;
                default:
                    Console.WriteLine("Kan inte läsa siffran");
                    break;
            }
            Console.ReadKey();
        }
    }
}
