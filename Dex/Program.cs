using System;
using System.Collections.Generic;
using System.Linq;

namespace Dex
{
    class Program
    {
        public static List<Client> listClient = new List<Client>();
        static void Main(string[] args)
        {
            var andrey1 = new Client("Котельцев Андрей Муратович", 1, 15_000);
            var ivan = new Client("Костюшев Иван Павлович", 2, 1_000);
            var vladimir = new Client("Рыбников Юрий Антонович", 3, 9_999);

            listClient.AddRange(new Client[] { ivan, andrey1, vladimir });
            var client1 = listClient.SearchClient(2);
            Console.WriteLine(client1.Fio + "\n");

            var client2 = listClient.SearchMinValue(10_000);
            foreach (var item in client2)
            {
                Console.WriteLine(item.Fio);
            }

            var client3 = listClient.SearchMin();
            Console.WriteLine("\n" + client3.Fio);

            var sum = listClient.SumAmount();
            Console.WriteLine($"\nСумма денег всех клиентов составляет: {sum}");


            Console.ReadLine();
        }
    }
}
