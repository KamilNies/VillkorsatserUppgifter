using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Skriv ett program som lägger till bonus till givna poäng. Poängen är
            mellan 1 och 9. Programmet läser en siffra som indata. Om siffran är
            ▫ mellan 1 och 3: multiplicera med 10
            ▫ mellan 4 och 6: multiplicera med 100
            ▫ mellan 7 och 9: multiplicera med 1000
            ▫ noll eller inte en siffra: skriv ut felmeddelande
            Använd en switch och avsluta med att skriva ut det nya värdet på
            konsolen */
            Console.Write("Input a number between 1 and 9: ");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Output after operation is: {0}", input * 10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Output after operation is: {0}", input * 100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Output after operation is: {0}", input * 1000);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            Console.ReadKey();
        }
    }
}
