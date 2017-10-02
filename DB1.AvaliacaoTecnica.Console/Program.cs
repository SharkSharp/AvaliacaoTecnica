using DB1.AvaliacaoTecnica.Console.Ex1;
using System.Diagnostics;

using MyEx2 = DB1.AvaliacaoTecnica.Console.Ex2.Ex2;
using MyEx3 = DB1.AvaliacaoTecnica.Console.Ex3.Ex3;

namespace DB1.AvaliacaoTecnica.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                PrintMenu();
                input = System.Console.ReadLine().ToLower();
                switch (input)
                {
                    case "1":
                            SolveEx1();
                        break;

                    case "2":
                            SolveEx2();
                        break;

                    case "3":
                            SolveEx3();
                        break;

                    case "exit":
                        break;

                    default:
                            System.Console.WriteLine("|--------------------------Command not found.-------------------------|");
                        break;
                }                

            } while (input != "exit");
        }

        static void PrintMenu()
        {
            System.Console.WriteLine("|-----------------------Exercise selection menu-----------------------|");
            System.Console.WriteLine("|---------------------------------------------------------------------|");
            System.Console.WriteLine("|                        Type 1 to execute Ex1.                       |");
            System.Console.WriteLine("|                        Type 2 to execute Ex2.                       |");
            System.Console.WriteLine("|                        Type 3 to execute Ex3.                       |");
            System.Console.WriteLine("|                        Type exit to finish.                         |");
            System.Console.WriteLine("|---------------------------------------------------------------------|");
        }

        static void SolveEx1()
        {
            System.Console.WriteLine("|---------------------------------------------------------------------|");
            System.Console.WriteLine("| Finding the number between 1 and 1.000.000 that generate the largest|");
            System.Console.WriteLine("|                          Collatz's sequence                         |");
            System.Console.WriteLine("|---------------------------------------------------------------------|");

            var watch = Stopwatch.StartNew();
            long awser = Collatz.CollatzMaxLengthInRange(1, 1000000);
            watch.Stop();

            System.Console.ForegroundColor = System.ConsoleColor.Green;
            System.Console.WriteLine("                       The awnser is: {0:0000000000}                       ", awser);
            System.Console.WriteLine("                            Found in: {0:0000000000} ms                    ", watch.ElapsedMilliseconds);
            System.Console.ForegroundColor = System.ConsoleColor.Gray;

            System.Console.WriteLine();
        }

        static void SolveEx2()
        {
            int[] numbers = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };


            System.Console.WriteLine("|---------------------------------------------------------------------|");
            System.Console.WriteLine("|                    Are there only odd numbers in                    |");
            System.Console.WriteLine("|              { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 }             |");
            System.Console.WriteLine("|---------------------------------------------------------------------|");

            System.Console.ForegroundColor = System.ConsoleColor.Green;
            System.Console.WriteLine("                           The awnser is: {0:5}                        ", MyEx2.AreOnlyOddNumbers(numbers));
            System.Console.ForegroundColor = System.ConsoleColor.Gray;

            System.Console.WriteLine();
        }

        static void SolveEx3()
        {
            int[] firstArray = { 1, 3, 7, 29, 42, 98, 234, 93 };
            int[] secondArray = { 4, 6, 93, 7, 55, 32, 3 };

            int[] result = MyEx3.Difference(firstArray, secondArray);

            string strResult = "{ ";

            for (int i = 0; i < result.Length - 1; i++)
            {
                strResult += result[i] + ", ";
            }
            strResult += result[result.Length - 1];
            strResult += " }";

            System.Console.WriteLine("|---------------------------------------------------------------------|");
            System.Console.WriteLine("|         Numbers that are in { 1, 3, 7, 29, 42, 98, 234, 93 }        |");
            System.Console.WriteLine("|                and not in { 4, 6, 93, 7, 55, 32, 3 }                |");
            System.Console.WriteLine("|---------------------------------------------------------------------|");

            System.Console.ForegroundColor = System.ConsoleColor.Green;
            System.Console.WriteLine("                    The awnser is: {0:22}              ", strResult);
            System.Console.ForegroundColor = System.ConsoleColor.Gray;
            System.Console.WriteLine();
        }
    }
}
