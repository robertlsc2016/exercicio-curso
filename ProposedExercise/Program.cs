using System.Globalization;

namespace ProposedExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double InitialDepositValue = 0;

            Console.WriteLine("Número da conta:");
            double AccountNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Nome do Titular da conta");
            string AccountName = Console.ReadLine();

            Console.WriteLine("Fazer depósito? (s/n)");
            string DepositConfirmation = Console.ReadLine();

            if (DepositConfirmation == "s")
            {
                Console.WriteLine("Valor do depososito: ");
                InitialDepositValue = double.Parse(Console.ReadLine());
            }

            Account Account = new Account(AccountNumber, AccountName, InitialDepositValue);


            Console.WriteLine("Dados da conta: ");
            Console.WriteLine($"Conta: ${Account.AccountNumber}, Titular: {Account.AccountName}, Saldo Atual: R$ {Account.AccountBalance.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("valor para depositar: ");
            double DepositValue = double.Parse(Console.ReadLine());
            Account.AddBalance(DepositValue);
            Console.WriteLine($"Conta: ${Account.AccountNumber}, Titular: {Account.AccountName}, Saldo Atual: R$ {Account.AccountBalance.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("Valor para sacar: ");
            double WithdrawValue = double.Parse(Console.ReadLine());
            Account.WithDraw(WithdrawValue);
            Console.WriteLine($"Conta: ${Account.AccountNumber}, Titular: {Account.AccountName}, Saldo Atual: R$ {Account.AccountBalance.ToString("F2", CultureInfo.InvariantCulture)}");





        }
    }
}