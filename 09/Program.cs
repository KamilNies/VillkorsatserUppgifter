using System;
using System.Linq;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Skriv ett program som läser in fem heltal och kontrollerar ifall summan
            av någon delmängd av talen är 0 (noll).
            Exempel: 3, -2, 1, 1, 8 → 1+1-2=0 */

            //int[] input = { 3, -2, 1, 1, 8 }; // 1 1 1 -2 -2 does not work
            //Array.Sort(input);
            //Array.Reverse(input);
            //int sum = 0;
            //bool flag = true;
            //foreach (var item in input)
            //{
            //    sum += item;
            //}
            //if (sum == 0)
            //{
            //    Console.WriteLine("\nThe sum of all items in the array equals 0");
            //}
            //else
            //{
            //    for (int i = 0; i < input.Length; i++)
            //    {
            //        if (flag)
            //        {
            //            sum = input[i];
            //            for (int j = 0; j < input.Length; j++)
            //            {
            //                if (i != input.Length - 1 - j)
            //                {
            //                    sum += input[input.Length - 1 - j];
            //                    if (sum == 0)
            //                    {
            //                        Console.WriteLine("\nThe sum of some subsets in array equal 0");
            //                        flag = false;
            //                        break;
            //                    }
            //                    else
            //                    {
            //                        continue;
            //                    }
            //                }
            //            }
            //        }
            //    }
            //    if (flag)
            //    {
            //        Console.WriteLine("\nThere are no sum of subsets in the array that equal 0");
            //    }
            //}
            //Console.ReadKey();

            int[] inputArray = { 7, 1, -3, 2, -1 };
            Array.Sort(inputArray);
            Array.Reverse(inputArray); //8, 3, 1, 1, -2
            var arrayLength = inputArray.Length;
            var stringResults = "";
            var breakLoop = true;

            if (inputArray.Sum() == 0)
            {
                Console.WriteLine("The sum of all the numbers resulted in 0");
            }
            else
            {
                for (int x = 0; x < arrayLength; x++)
                {
                    var results = inputArray[x];
                    stringResults += inputArray[x].ToString();
                    for (int y = arrayLength - 1; y > x; y--)
                    {
                        int z = 1;
                        results += inputArray[y];
                        while (results <= 0 && breakLoop && z < (arrayLength - y))
                        {
                            stringResults += " + " + inputArray[y - z].ToString();
                            if (results == 0)
                            {
                                breakLoop = false;
                                Console.WriteLine(stringResults + " = 0");
                            }
                            results += inputArray[y - z];
                            z++;
                        }
                        stringResults += " + " + inputArray[y].ToString();
                    }
                    results = inputArray[x];
                    stringResults = "";
                }
                if (breakLoop)
                {
                    Console.WriteLine("None of the numbers equaled 0.");
                }
            }
            Console.ReadKey();
        }
    }
}
