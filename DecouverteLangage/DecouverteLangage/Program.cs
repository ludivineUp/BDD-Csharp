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
        public static void ExoHeritage()
        {
            Personne pers = new Employe("n", "p", DateTime.Now, 10);

            Employe employe = pers.Clone() as Employe;

            Personne[] Personnes = new Personne[5];
            //Des Affectations utilisant le concept du polymorphisme
            Personnes[0] = new Personne("NOM1", "PRENOM1", new DateTime(1985, 3, 4));
            Personnes[1] = new Employe("NOM2", "PRENOM2", new DateTime(1984, 3, 4), 10000).Clone() as Employe;
            Personnes[2] = new Employe("NOM3", "PRENOM3", new DateTime(1983, 3, 4), 8000);
            Personnes[3] = new Employe("NOM4", "PRENOM4", new DateTime(1982, 3, 4), 11000);
            Personnes[4] = new Employe("NOM5", "PRENOM5", new DateTime(1981, 3, 4), 7000);

            foreach (Personne p in Personnes)
            {
                WriteLine(p.Afficher());
            }

            ITravailleur[] travailleurs = new Personne[5];
            //Des Affectations utilisant le concept du polymorphisme
            travailleurs[0] = new Personne("NOM1", "PRENOM1", new DateTime(1985, 3, 4));
            travailleurs[1] = new Employe("NOM2", "PRENOM2", new DateTime(1984, 3, 4), 10000).Clone() as Employe;
            travailleurs[2] = new Employe("NOM3", "PRENOM3", new DateTime(1983, 3, 4), 8000);
            travailleurs[3] = new Employe("NOM4", "PRENOM4", new DateTime(1982, 3, 4), 11000);
            travailleurs[4] = new Employe("NOM5", "PRENOM5", new DateTime(1981, 3, 4), 7000);

            foreach (ITravailleur p in travailleurs)
            {
                WriteLine(p.Afficher());
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ExoHeritage();
        }
    }
}

