using System;
using System.Collections.Generic;
using System.Text;

namespace Dex
{
    public class Client
    {
        public string Fio { get; set; }
        public int PassportId { get; set; }
        public decimal AccountAmount { get; set; }

        public Client() { }
        public Client(string fio, int passportId, decimal accountAmount)
        {
            Fio = fio;
            PassportId = passportId;
            AccountAmount = accountAmount;
        }

    }
}
