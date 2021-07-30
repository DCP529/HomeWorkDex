using System;
using System.Collections.Generic;
using System.Text;

namespace Dex
{
    public static class Extension
    {
        public static Client SearchClient(this List<Client> listClient, int passportId)
        {
            foreach (var item in listClient)
            {
                if (item.PassportId == passportId)
                {
                    return item;
                }
            }
            return null;
        }

        public static List<Client> SearchMinValue(this List<Client> listClient, int value) // ищет клиентов у которых сумма меньше указанной
        {
            List<Client> result = new List<Client>();

            foreach (var item in listClient)
            {
                if (item.AccountAmount < value)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public static Client SearchMin(this List<Client> listClient)
        {
            Client minAmount;
            for (int i = 0; i < listClient.Count; i++)
            {
                for (int j = i + 1; j < listClient.Count; j++)
                {
                    if (listClient[i].AccountAmount > listClient[j].AccountAmount)
                    {
                        minAmount = listClient[i];
                        listClient[i] = listClient[j];
                        listClient[j] = minAmount;
                    }
                }
            }
            return listClient[0];
        }

        public static decimal SumAmount(this List<Client> listClient)
        {
            decimal sum = 0;
            foreach (var item in listClient)
            {
                sum += item.AccountAmount;
            }
            return sum;
        }
    }
}