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
            var newAccount = new BankAccount("Angela", 10000);

            Console.WriteLine($"An Account with number {newAccount.AccountNumber} has been successfully created for {newAccount.AccountOwner}");
            
        }        
    }
}
