using System;
using static System.Console;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DecouverteLangage
{


    class Program
    {
        public static void M1()
        {
            WriteLine("Hello");
            WriteLine("World");
        }
        public static string GetStringFromConsole()
        {
            var input = ReadLine();

            while (string.IsNullOrWhiteSpace(input))
            {
                WriteLine("Entrée incorrecte, veuilllez réessayer");
                input = ReadLine();
            }

            return input;
        }

        public static int GetIntFromConsole()
        {
            int inputNumber;
            var input = GetStringFromConsole();

            while (!int.TryParse(input, out inputNumber))
            {
                WriteLine("Entrée incorrecte, veuilllez réessayer");
                input = ReadLine();
            }

            return inputNumber;
        }
        public static void M3()
        {
            var s1 = GetStringFromConsole();
            var s2 = GetStringFromConsole();
            var s3 = GetStringFromConsole();

            WriteLine(s3);
            WriteLine(s2);
            WriteLine(s1);
        }
        public static void M4()
        {
            var number1 = GetIntFromConsole();
            var number2 = GetIntFromConsole();

            WriteLine(number1 == number2 ? "Egaux" : "Différent");
        }
        public static void M7()
        {
            var number1 = GetIntFromConsole();
            var number2 = GetIntFromConsole();
            var number3 = GetIntFromConsole();
            var number4 = GetIntFromConsole();

            WriteLine((((double)number1 + number2 + number3 + number4) / 4));
        }
        public static void M18()
        {
            var letter = GetStringFromConsole();
            int i, j, spc, rows, k;

            rows = GetIntFromConsole();
            spc = rows - 1; // Espace à gauche
            for (i = 1; i <= rows; i++)
            {
                for (k = spc; k >= 1; k--)
                {
                    Write(" ");
                }

                for (j = 1; j <= i; j++)
                    Write(letter + " ");

                Write("\n");
                spc--;
            }
        }
        public static void M22()
        {
            WriteLine((DateTime.Now.AddMonths(1).AddDays(10) - DateTime.Now).TotalDays + " jours de différence");
        }
        public static void M28()
        {
            string s1 = GetStringFromConsole();
            string s2 = GetStringFromConsole();

            WriteLine(string.Compare(s1, s2, true) == 0 ? "égales" : "différentes");
        }
        public static void M29()
        {
            var mot = GetStringFromConsole();
            bool palindrome = true;
            for (int i = 0; i < mot.Length / 2; i++)
            {
                if (mot[i] != mot[mot.Length - 1 - i])
                {
                    palindrome = false;
                    break;
                }
            }
            if (palindrome)
                WriteLine("Le mot est un palindrome");
            else
                WriteLine("Le mot n est pas un palindrome");
        }
        public static void M30()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("fizz");
                    if (i % 5 == 0)
                        Console.Write("buzz ");
                    else
                        Console.Write(" ");
                }
                else if (i % 5 == 0)
                    Console.Write("buzz ");
                else
                    Console.Write(i + " ");
                if (i % 10 == 9)
                    Console.WriteLine();
            }
        }
        public static void ExoClass()
        {
            var myPersonS = new Personne("Nom1", "Prenom2", DateTime.Now.AddYears(-50));
            var myPersonS2 = myPersonS.Clone();

            myPersonS.Inverser();

            WriteLine(myPersonS);
            WriteLine(myPersonS2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ExoClass();
        }
    }
}

