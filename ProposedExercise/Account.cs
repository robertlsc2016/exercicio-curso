using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProposedExercise
{
    internal class Account
    {
        public double AccountNumber { get; private set; }
        public string AccountName { get; private set; }
        public double AccountBalance { get; private set; }


        public Account(double accountNumber, string accountName, double accountBalance)
        {
            AccountNumber = accountNumber;
            AccountName = accountName;
            AccountBalance = accountBalance;
        }

        public void AddBalance(double balance)
        {
            AccountBalance += balance;
        }

        public void WithDraw(double withdraw)
        {
            AccountBalance -= withdraw + 5;
        }


    }
}
