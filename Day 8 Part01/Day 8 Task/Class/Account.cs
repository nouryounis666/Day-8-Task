using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_Task
{
    internal struct Account
    {
        private int accountId;
        private string accountHolder;
        private decimal balance;
        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }

        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}
