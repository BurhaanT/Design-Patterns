using System;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            const string SavingsAccNo = "SAV1234";
            const string ChequeAccNo = "CHQ1234";


            AccountFactory factory = new AccountFactory();
            var savingsAccount = factory.GetAccount(SavingsAccNo);
            var chequeAccount = factory.GetAccount(ChequeAccNo);

            Console.WriteLine($"Savings balance: {savingsAccount.Balance}");
            Console.WriteLine($"Cheque balance: {chequeAccount.Balance}");

        }

    }

    public abstract class Account
    {
        public decimal Balance { get; set; }
    }

    public class Savings : Account
    {
        public Savings()
        {
            Balance = 1000;
        }
    }

    public class Cheque : Account
    {
        public Cheque()
        {
            Balance = 2000;
        }
    }

    interface IAccountFactory
    {
        Account GetAccount(string accNo);
    }

    public class AccountFactory: IAccountFactory
    {
        public Account GetAccount(string accNo)
        {
            if (accNo.Contains("sav", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Savings();
            }
            if (accNo.Contains("chq", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Cheque();
            }
            throw new ArgumentException("Invalid account number!");
        }
    }
}
