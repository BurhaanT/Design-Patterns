using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccount1 = BankAccount.Instance;
            Console.WriteLine($"Account Number: {bankAccount1.GetAccountNumber()}");

            var bankAccount2 = BankAccount.Instance;
            Console.WriteLine($"Account Number: {bankAccount2.GetAccountNumber()}");

            Console.ReadLine();
        }


        
    }
    class BankAccount
    {
        private Guid _accountNumber;
        private static BankAccount _instance;

        private BankAccount()
        {
            _accountNumber = Guid.NewGuid();
        }

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit (https://csharpindepth.com/articles/BeforeFieldInit)
        static BankAccount()
        {
        }

        public static BankAccount Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BankAccount();
                return _instance;
            }
        }

        public Guid GetAccountNumber() => _accountNumber;
    }
}
