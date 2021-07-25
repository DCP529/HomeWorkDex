using System;
using System.Diagnostics;

namespace Dex
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();

            int i = 123;
            object o = i; // упаковка            

            stopwatch.Stop();

            Console.WriteLine($"Потрачено времени на упаковку - {stopwatch.Elapsed}");

            stopwatch.Start();

            i = (int)o; // распаковка

            stopwatch.Stop();

            Console.WriteLine($"Потрачено времени на распаковку - {stopwatch.Elapsed}");

            Console.ReadLine();
        }

    }
}
