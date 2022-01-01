using BankSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;
using BankSystem.Operations;

namespace BankSystem
{
   public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountOwner { get; set; }
        public decimal Balance{
            get
            {
                decimal balance = 0;
                foreach (var item in AllTransactions)
                {
                    balance = balance + item.Amount;
                }
                return balance;
            }
         }
        private static int AccountNumberSeed = 1234567890;
        public List<Transaction> AllTransactions = new List<Transaction>();
        public BankAccount(string name, decimal initialBalance)
        {
            AccountOwner = name;
            AccountNumber = AccountNumberSeed.ToString();
            AccountNumberSeed++;
            Deposit(initialBalance, DateTime.Now, "Initial balance");

        }
        public void Deposit(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
                var deposit = new Transaction(amount, date, note);
                AllTransactions.Add(deposit);
            }
        }
        public void Withdraw(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            {
                Console.WriteLine("You cannot withdraw a negative amount");
            }
            if(Balance - amount < 0)
            {
                Console.WriteLine("Insufficient funds");
            }
            var withdraw = new Transaction(-amount, date, note);
            AllTransactions.Add(withdraw);
        }
    }
}
