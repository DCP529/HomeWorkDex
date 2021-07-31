using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Dex
{
    class Program
    {
        static void Main(string[] args)
        {
            var figures = new List<Figure>();
            var dic = new Dictionary<Figure, Client>();

            for (int i = 0; i < 100_000; i++)
            {
                figures.Add(new Figure() { SideCount = i, SideLength = 1 });
                dic.Add(figures[i], new Client());
            }

            Stopwatch sw = new Stopwatch();
            sw.Start();
            var findList = figures.Find(list => list.SideCount == 10_000);
            sw.Stop();

            Console.WriteLine(sw.Elapsed);

            sw.Restart();
            var findDic = dic.Where(dic => dic.Key.SideCount == 10_000);
            sw.Stop();

            Console.WriteLine(sw.Elapsed);
            Console.ReadLine();
        }
    }
}
