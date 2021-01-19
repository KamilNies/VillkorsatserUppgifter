using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Skriv ett program som läser in koefficienterna a, b och c för
            andragradsekvationen
            a*x2+b*x+c=0
            och beräknar och skriver ut dess reella rötter. Observera att
            andragradsekvationer kan ha 0, 1 eller 2 reella rötter.*/
            Console.WriteLine("a*x2+b*x+c\n");
            Console.Write("Skriv in ett värde för a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Skriv in ett värde för b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Skriv in ett värde för c: ");
            double c = double.Parse(Console.ReadLine());
            double diskriminant = b * b - 4 * a * c;
            if (a == 0)
            {
                Console.WriteLine("\nx = {0}", -c / b);
            }
            else if (diskriminant < 0)
            {
                Console.WriteLine("\n{0}*x2+{1}*x+{2} har inga reella rötter", a, b, c);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(diskriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(diskriminant)) / (2 * a);

                Console.WriteLine("\nx1 = {0:0.00}", x1);
                Console.WriteLine("x2 = {0:0.00}", x2);
            }

            Console.ReadKey();
        }
    }
}
