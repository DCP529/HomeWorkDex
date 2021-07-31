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

            IEnumerable<Client> client1 = SearchPassportId(listClient, 1);
            foreach (var item in client1)
            {
                Console.WriteLine(item.Fio);
            }

            IEnumerable<Client> client2 = SearchAmount(listClient, 10_000);
            foreach (var item in client2)
            {
                Console.WriteLine(item.Fio);
            }

            IEnumerable<Client> client4 = SearchMin(listClient);
            foreach (var item in client4)
            {
                Console.WriteLine(item.Fio);
            }

            Console.WriteLine(ClientSearchSum(listClient));

            Console.ReadLine();
        }

        public static IEnumerable<Client> SearchPassportId(List<Client> listClient, int passportId)
        {
            var result = listClient.Where(client => client.PassportId == passportId);
            return result;
        }

        public static IEnumerable<Client> SearchAmount(List<Client> listClient, int Amount)
        {
            var result = listClient.Where(client => client.AccountAmount < Amount);
            return result;
        }
        public static IEnumerable<Client> SearchMin(List<Client> listClient)
        {
            decimal min = listClient.Min(client => client.AccountAmount);
            var minAmount = listClient.FirstOrDefault(client => client.AccountAmount == min);
            var result = listClient.Where(client => client == minAmount);
            return result;

        }
        public static decimal ClientSearchSum(List<Client> listClient)
        {
            decimal sum = listClient.Sum(client => client.AccountAmount);
            return sum;
        }
    }
}
