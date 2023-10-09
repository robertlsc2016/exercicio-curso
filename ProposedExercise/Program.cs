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

            if (DepositConfirmation == "s" || DepositConfirmation == "S")
            {
                Console.WriteLine("Valor do depososito: ");
                InitialDepositValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Account Account = new Account(AccountNumber, AccountName, InitialDepositValue);


            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(Account.ToString());

            Console.WriteLine("valor para depositar: ");
            double DepositValue = double.Parse(Console.ReadLine());
            Account.AddBalance(DepositValue);
            Console.WriteLine(Account.ToString());

            Console.WriteLine("Valor para sacar: ");
            double WithdrawValue = double.Parse(Console.ReadLine());
            Account.WithDraw(WithdrawValue);
            Console.WriteLine(Account.ToString());





        }
    }
}