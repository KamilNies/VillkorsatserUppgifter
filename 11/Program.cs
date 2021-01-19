using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Skriv ett program som konverterar ett tal i intervallet [0..999] till text
            som motsvarar dess svenska eller engelska uttal. Exempel:

            Tal                 Svenska                         Engelska
            0                   Noll                            Zero
            273                 Två hundra sjuttio tre          Two hundred seventy three
            400                 Fyra hundra                     Four hundred
            501                 Fem hundra ett                  Five hundred and one
            711                 Sju hundra elva                 Seven hundred and eleven

            TIPS: engelska har litet mer komplicerade regler än svenska */

            Console.Write("Enter a value between 0 and 999: ");
            uint value = uint.Parse(Console.ReadLine());
            if (value < 10 && value > 0) //single digits
            {
                SingleDigit(value);
            }
            else if (value < 100 && value > 9) //double digits
            {
                DoubleDigits(value);
            }
            else if (value < 1000 && value > 99) //triple digits
            {
                TripleDigits(value);
            }
            else if (value == 0) // zero
            {
                Console.WriteLine("Zero");
            }
            else //anything else. In this case, when input > 999
            {
                throw new ApplicationException("Invalid input");
            }
            Console.ReadKey();
        }
        public static void SingleDigit(uint value)
        {
            string strValue = value.ToString();
            if (strValue.Length != 1 || strValue[0] == '0')
            {
                throw new ApplicationException("Invalid input");
            }
            switch (strValue[0])
            {
                case '1':
                    Console.Write("One");
                    break;
                case '2':
                    Console.Write("Two");
                    break;
                case '3':
                    Console.Write("Three");
                    break;
                case '4':
                    Console.Write("Four");
                    break;
                case '5':
                    Console.Write("Five");
                    break;
                case '6':
                    Console.Write("Six");
                    break;
                case '7':
                    Console.Write("Seven");
                    break;
                case '8':
                    Console.Write("Eight");
                    break;
                case '9':
                    Console.Write("Nine");
                    break;
            }
        }
        public static void DoubleDigits(uint value)
        {
            string strValue = value.ToString();
            if (strValue.Length != 2 || strValue[0] == '0')
            {
                throw new ApplicationException("Invalid input");
            }
            switch (strValue[0])
            {
                case '1':
                    switch (strValue[1])
                    {
                        case '0':
                            Console.Write("Ten");
                            break;
                        case '1':
                            Console.Write("Eleven");
                            break;
                        case '2':
                            Console.Write("Twelve");
                            break;
                        case '3':
                            Console.Write("Thirteen");
                            break;
                        case '4':
                            Console.Write("Fourteen");
                            break;
                        case '5':
                            Console.Write("Fifteen");
                            break;
                        case '6':
                            Console.Write("Sixteen");
                            break;
                        case '7':
                            Console.Write("Seventeen");
                            break;
                        case '8':
                            Console.Write("Eighteen");
                            break;
                        case '9':
                            Console.Write("Nineteen");
                            break;
                    }
                    break;
                case '2':
                    Console.Write("Twenty ");
                    break;
                case '3':
                    Console.Write("Thirty ");
                    break;
                case '4':
                    Console.Write("Forty ");
                    break;
                case '5':
                    Console.Write("Fifty ");
                    break;
                case '6':
                    Console.Write("Sixty ");
                    break;
                case '7':
                    Console.Write("Seventy ");
                    break;
                case '8':
                    Console.Write("Eighty ");
                    break;
                case '9':
                    Console.Write("Ninety ");
                    break;
            }
            if (strValue[0] != 1)
            {
                switch (strValue[1])
                {
                    case '0':
                        Console.Write("");
                        break;
                    case '1':
                        Console.Write("one");
                        break;
                    case '2':
                        Console.Write("two");
                        break;
                    case '3':
                        Console.Write("three");
                        break;
                    case '4':
                        Console.Write("four");
                        break;
                    case '5':
                        Console.Write("five");
                        break;
                    case '6':
                        Console.Write("six");
                        break;
                    case '7':
                        Console.Write("seven");
                        break;
                    case '8':
                        Console.Write("eight");
                        break;
                    case '9':
                        Console.Write("nine");
                        break;
                }
            }
        }
        public static void TripleDigits(uint value)
        {
            string strValue = value.ToString();
            if (strValue.Length != 3 || strValue[0] == '0')
            {
                throw new ApplicationException("Invalid input");
            }
            switch (strValue[0])
            {
                case '1':
                    Console.Write("One hundred ");
                    break;
                case '2':
                    Console.Write("Two hundred ");
                    break;
                case '3':
                    Console.Write("Three hundred ");
                    break;
                case '4':
                    Console.Write("Four hundred ");
                    break;
                case '5':
                    Console.Write("Five hundred ");
                    break;
                case '6':
                    Console.Write("Six hundred ");
                    break;
                case '7':
                    Console.Write("Seven hundred ");
                    break;
                case '8':
                    Console.Write("Eight hundred ");
                    break;
                case '9':
                    Console.Write("Nine hundred ");
                    break;
            }
            switch (strValue[1])
            {
                case '0':
                    Console.Write("and ");
                    break;
                case '1':
                    switch (strValue[2])
                    {
                        case '0':
                            Console.Write("ten");
                            break;
                        case '1':
                            Console.Write("eleven");
                            break;
                        case '2':
                            Console.Write("twelve");
                            break;
                        case '3':
                            Console.Write("thirteen");
                            break;
                        case '4':
                            Console.Write("fourteen");
                            break;
                        case '5':
                            Console.Write("fifteen");
                            break;
                        case '6':
                            Console.Write("sixteen");
                            break;
                        case '7':
                            Console.Write("seventeen");
                            break;
                        case '8':
                            Console.Write("eighteen");
                            break;
                        case '9':
                            Console.Write("nineteen");
                            break;
                    }
                    break;
                case '2':
                    Console.Write("twenty ");
                    break;
                case '3':
                    Console.Write("thirty ");
                    break;
                case '4':
                    Console.Write("forty ");
                    break;
                case '5':
                    Console.Write("fifty ");
                    break;
                case '6':
                    Console.Write("sixty ");
                    break;
                case '7':
                    Console.Write("seventy ");
                    break;
                case '8':
                    Console.Write("eighty ");
                    break;
                case '9':
                    Console.Write("ninety ");
                    break;
            }
            if (strValue[1] != 1)
            {
                switch (strValue[2])
                {
                    case '0':
                        Console.Write("");
                        break;
                    case '1':
                        Console.Write("one");
                        break;
                    case '2':
                        Console.Write("two");
                        break;
                    case '3':
                        Console.Write("three");
                        break;
                    case '4':
                        Console.Write("four");
                        break;
                    case '5':
                        Console.Write("five");
                        break;
                    case '6':
                        Console.Write("six");
                        break;
                    case '7':
                        Console.Write("seven");
                        break;
                    case '8':
                        Console.Write("eight");
                        break;
                    case '9':
                        Console.Write("nine");
                        break;
                }
            }
        }
    }
}
