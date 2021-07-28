using System;
using System.Diagnostics;

namespace Dex
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch1 = new Stopwatch();
            var stopwatch2 = new Stopwatch();

            int j = 1;
            object o = j;
            for (int i = 0; i < 100; i++)
            {
                stopwatch1.Start();
                j = i;
                o = j;// упаковка       
                stopwatch1.Stop();

                stopwatch2.Start();
                j = (int)o; // распаковка
                stopwatch2.Stop();
            }


            Console.WriteLine($"Среднее время отраченое на упаковку - {stopwatch1.Elapsed / 100}");

            Console.WriteLine($"Среднее время отраченое на распаковку - {stopwatch2.Elapsed / 100}");

            Console.ReadLine();
        }

    }
}
