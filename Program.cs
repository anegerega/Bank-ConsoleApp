using BankSystem.Models;
using System;
using System.Collections.Generic;
using BankSystem.Operations;

namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<<<<<<<<<<<<<<< WELCOME TO PRESTIGE BANK >>>>>>>>>>>>>");
            var newAccount = new BankAccount("Angela", 5000);
            Console.WriteLine($"An Account with number {newAccount.AccountNumber} has been successfully created for {newAccount.AccountOwner} with account balance of {newAccount.Balance}");

            newAccount.Withdraw(500, DateTime.Now, "Food");
            Console.WriteLine(newAccount.Balance);

            newAccount.Deposit(-350, DateTime.Now, "money");
        }      
    }
}

