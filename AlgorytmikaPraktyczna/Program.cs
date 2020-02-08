using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using SortowanieDanych;

namespace AlgorytmikaPraktyczna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Testowanie algorytmów sortowania.\nWybierz sposób sortowania: (1 - Bąbelkowe, 2 - Sortowanie przez scalanie, 3 - Sortowanie szybkie, 4 - Sortowanie przy użycoi LINQ");
            Console.WriteLine("Naciśnij Q lub ESCAPE aby wyjść.\n");

            var key = Console.ReadKey();
            Console.WriteLine("Podaj liczbe powtórzeń:");
            int n = ReadValidIntegerNumber();
            while (n > 20)
            {
                Console.WriteLine("To by trwało stanowczo za długo...");
                n = ReadValidIntegerNumber();
            }
            bool stop = false;
            while (!stop)
            {
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.WriteLine("Sortowanie bąbelkowe.\n");
                        TestSort(n, array => array.BubbleSort());
                        Console.WriteLine("Zakończono. Wybierzk kolejne dzialanie.\n");
                        key = Console.ReadKey();
                        Console.WriteLine();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.WriteLine("Sortowanie przez scalanie.\n");
                        TestSort(n, array => array.MergeSort());
                        Console.WriteLine("Zakończono. Wybierzk kolejne dzialanie.\n");
                        key = Console.ReadKey();
                        Console.WriteLine();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.WriteLine("Sortowanie szybkie.\n");
                        TestSort(n, array => array.QuickSort());
                        Console.WriteLine("Zakończono. Wybierzk kolejne dzialanie.\n");
                        key = Console.ReadKey();
                        Console.WriteLine();
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.WriteLine("Sortowanie LINQ.\n");
                        TestSort(n, array => array.LinqSort());
                        Console.WriteLine("Zakończono. Wybierzk kolejne dzialanie.\n");
                        key = Console.ReadKey();
                        Console.WriteLine();
                        break;
                    case ConsoleKey.Q:
                    case ConsoleKey.Escape:
                        stop = true;
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowa wartość. Spróbuj jeszcze raz.\n");
                        key = Console.ReadKey();
                        Console.WriteLine();
                        break;
                }
            }

        }

        private static int ReadValidIntegerNumber()
        {
            var key = Console.ReadLine();
            int result = 0;
            while (!int.TryParse(key, out result) || result<= 0)
            {
                Console.WriteLine("Nieprawidłowa wartość. Spróbuj jeszcze raz.");
                key = Console.ReadLine();
            }

            return result;

        }

        private static void TestSort(int repeat, Action<int[]> sort)
        {
            var n = 100;
            for (var i = 1; i <= repeat; i++)
            {
                var intArray = new int[n];
                var random = new Random(1001);

                for (var j = 0; j < n; j++)
                {
                    intArray[j] = random.Next();
                }

                intArray[n / 2] = 1;

                var watch = new Stopwatch();
                watch.Restart();
                sort(intArray);
                watch.Stop();

                Console.WriteLine($"Sortowanie {n} elementów zajęło: {watch.Elapsed.TotalSeconds:F} sekund, {watch.Elapsed.TotalMilliseconds:F} milisekund))");
                n *= 2;
            }
        }
    }
}