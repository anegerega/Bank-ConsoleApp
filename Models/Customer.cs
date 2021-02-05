using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem.Models
{
    class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public int birthYear { get; set; }
        public string accountType { get; set; }
        public DateTime dateCreated { get; set; }
        public int accountNumber { get; set; } = GenerateAccountNum();
        //public List<Customer> Customers { get; set; }
        public decimal balance { get; set; }

        public static int GenerateAccountNum()
        {
            Random num = new Random();
            int AcctNum = num.Next(100001, 199999);
            return AcctNum;
        }        
    }
}
