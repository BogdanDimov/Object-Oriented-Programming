namespace OOP_Principles_Part2.Problem_2._Bank_accounts
{
    using System;
    using OOP_Principles_Part2.Problem_2._Bank_accounts.Models;

    public class TestBankSystem
    {
        public static void Test()
        {
            var bank = new Bank("Fastak Bank");

            bank.AddAccount(new DepositAccount(new Individual("Petar Petrov"), 1500, 1));
            bank.AddAccount(new LoanAccount(new Company("Kukumyavka Solutions"), 5000, 5));
            bank.AddAccount(new MortgageAccount(new Individual("Atanas Atanasov"), 500, 0.5m));
            bank.AddAccount(new DepositAccount(new Company("Harabia Inc."), 10000, 2.5m));
            bank.AddAccount(new LoanAccount(new Individual("Tsenko Chokov"), 2200, 1.5m));

            Console.WriteLine(bank);

            Console.WriteLine("\nInterest for next 12 mounts:");
            foreach (var account in bank.Accounts)
            {
                Console.WriteLine("{0}  -> {1:F3} per month", account.Customer.Name, account.CalculateInterest(12));
            }

            Console.WriteLine();
        }
    }
}
