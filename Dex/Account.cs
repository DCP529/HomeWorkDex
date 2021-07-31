using System;
using System.Collections.Generic;
using System.Text;

namespace Dex
{
    public class Account
    {
        decimal Money { get; set; }
        Currency CurrencyType { get; set; }

        public Account()
        {

        }
        public Account(decimal money, Currency currencyType)
        {
            Money = money;
            CurrencyType = currencyType;
        }
    }
}
