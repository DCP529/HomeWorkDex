using System;
using System.Diagnostics;

namespace Dex
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch1 = new Stopwatch();

            stopwatch1.Start();

            int i = 123;
            object o = i; // упаковка            

            stopwatch1.Stop();

            Console.WriteLine($"Потрачено времени на упаковку - {stopwatch1.Elapsed}");

            var stopwatch2 = new Stopwatch();

            stopwatch2.Start();

            i = (int)o; // распаковка

            stopwatch2.Stop();

            Console.WriteLine($"Потрачено времени на распаковку - {stopwatch2.Elapsed}");

            Console.ReadLine();
        }

    }
}
