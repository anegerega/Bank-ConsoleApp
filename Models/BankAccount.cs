﻿using BankSystem.Models;
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
            Balance = initialBalance;
            AccountNumber = AccountNumberSeed.ToString();
            AccountNumberSeed++;

        }
        public void Deposit(decimal amount, DateTime date, string note)
        {

        }
        public void Withdraw(decimal amount, DateTime date, string note)
        {

        }
    }
}
