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

            Console.WriteLine("How may we be of help to you today?");
            Console.WriteLine("1. Open an account");
            Console.WriteLine("2. Login to your account");
            Console.WriteLine("3 .Exit");

            string userchoice = Console.ReadLine();

            switch (userchoice)
            {
                case "1":
                    Console.WriteLine("");
                    break;
                case "2":
                    Console.WriteLine("");
                    break;
                case "3":
                    Console.WriteLine("");
                    break;
            }

                    var newAccount = new BankAccount("Angela", 5000);
            Console.WriteLine($"An Account with number {newAccount.AccountNumber} has been successfully created for {newAccount.AccountOwner} with account balance of {newAccount.Balance}");

            newAccount.Withdraw(500, DateTime.Now, "Food");
            Console.WriteLine(newAccount.Balance);

            newAccount.Deposit(-350, DateTime.Now, "money");
        }      
    }
}

