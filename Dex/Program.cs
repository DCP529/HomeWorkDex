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

            var account1 = new Account(150, new Rub());
            var account2 = new Account(100, new Ua());
            var account3 = new Account(200, new Rub());


            var client1= new Client("", 1, new List<Account>()
            {
                account1, account2, account3
            });

            var client2 = new Client("", 2, new List<Account>()
            {
                account1
            });

            var client3 = new Client("", 3, new List<Account>()
            {
                account2, account1
            });                      

            Dictionary<Client, Account> persons = new Dictionary<Client, Account>()
            {
                { client1, account1},
                { client2, account2},
                { client3, account3}
            };

            Console.ReadLine();
        }
    }
}
