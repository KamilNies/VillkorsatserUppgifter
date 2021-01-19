using System;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Skriv ett program som hittar det största av 5 givna tal */
            int[] femTal = new int[5];
            Console.Write("Skriv in 1:a heltal: ");
            femTal[0] = int.Parse(Console.ReadLine());
            Console.Write("Skriv in 2:a heltal: ");
            femTal[1] = int.Parse(Console.ReadLine());
            Console.Write("Skriv in 3:e heltal: ");
            femTal[2] = int.Parse(Console.ReadLine());
            Console.Write("Skriv in 4:e heltal: ");
            femTal[3] = int.Parse(Console.ReadLine());
            Console.Write("Skriv in 5:e heltal: ");
            femTal[4] = int.Parse(Console.ReadLine());

            int mest = 0;
            for (int i = 0; i < femTal.Length; i++)
            {
                if (femTal[i] > mest)
                {
                    mest = femTal[i];
                }
            }
            Console.WriteLine("\nDet största talet är {0}", mest);
            Console.ReadKey();
        }
    }
}
