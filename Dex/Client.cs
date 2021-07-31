using System;
using System.Collections.Generic;
using System.Text;

namespace Dex
{
    public class Client
    {
        public string Fio { get; set; }
        public int PassportId { get; set; }
        public List<Account> AccountList { get; set; } 

        public Client() { }
        public Client(string fio, int passportId, List<Account> accountAmount)
        {
            Fio = fio;
            PassportId = passportId;
            AccountList = accountAmount;
        }

    }
}
