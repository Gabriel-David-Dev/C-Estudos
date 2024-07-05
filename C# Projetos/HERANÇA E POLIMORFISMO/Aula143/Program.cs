using Aula143.Entities;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace Aula143
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Gabriel", 500.00, 0.01));
            list.Add(new BusinessAccount(1002, "Isabella", 500.00, 200.00));
            list.Add(new SavingsAccount(1003, "Marrye", 500.00, 0.02));
            list.Add(new BusinessAccount(1004, "Fumacinha", 500.00, 400.00));


            double sum = 0.0;

            foreach(Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine($"Total balance: {sum.ToString("F2", CultureInfo.InvariantCulture)}");

            foreach(Account acc in list)
            {
                acc.Withdraw(10.0);
            }

            foreach(Account acc in list)
            {
                Console.WriteLine($"Update balance for account {acc.Number}: " +
                    $"{acc.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
