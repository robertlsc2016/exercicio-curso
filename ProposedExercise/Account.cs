using System;
using System.Collections.Generic;
using System.Globalization;
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


        public Account(double accountNumber, string accountName)
        {
            AccountNumber = accountNumber;
            AccountName = accountName;
        }

        public Account(double accountNumber, string accountName, double accountBalance) : this(accountNumber, accountName)
        {
            AddBalance(accountBalance);
        }

        public override string ToString()
        {
            return $"Conta: {AccountNumber}, Titular: {AccountName}, Saldo Atual: R$ {AccountBalance.ToString("F2", CultureInfo.InvariantCulture)}";
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
