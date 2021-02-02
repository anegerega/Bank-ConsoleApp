using BankSystem.Models;
using System;
using System.Collections.Generic;

namespace BankSystem
{
    class Program
    {
        public static List<Customer> Customers { get; set; }

        static void Main(string[] args)
        {
            
          Begin:  Console.WriteLine("<<<<<<<<<<<<<<<< WELCOME TO PRESTIGE BANK >>>>>>>>>>>>>");
            Console.WriteLine("How may we be of help to you today?");
            Console.WriteLine("1. Open an account");
            Console.WriteLine("2. Login to your account");
            Console.WriteLine("3. Deposit into an account");
            Console.WriteLine("4. Check your account balance");
            Console.WriteLine("5. Transfer money");
            Console.WriteLine("6. Withdraw money from account");
            Console.WriteLine("7. Generate your account statement");
            Console.WriteLine("8. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":                
                    CreateAccount();
                    break;
                case "2":
                    LoginAccount();
                    break;
                case "3":
                    Deposit();
                    break;
                case "4":
                    CheckBalance();
                    break;
                case "5":
                    TransferFunds();
                    break;
                case "6":
                    Withdraw();
                    break;
                case "7":
                    GenerateStatement();
                    break;
                case "8":
                    Console.WriteLine("Goodbye");
                    break;
            }
            goto Begin;
        }
        public static void CreateAccount()
        {
            Console.WriteLine("Please fill in the following details");
            Console.Write("First Name: ");
            string FN = Console.ReadLine();

            Console.Write("Last Name: ");
            string LN = Console.ReadLine();

            Console.Write("In what year were you born: ");
            int BY = Convert.ToInt32(Console.ReadLine());

            Console.Write("Email Address: ");
            string EA = Console.ReadLine();

            Console.Write("Type of account (Savings/Current): ");
            string AT = Console.ReadLine();

            Customer customer = new Customer()
            {
                firstName = FN,
                lastName = LN,
                emailAddress = EA,
                birthYear = BY,
                accountType = AT,
                accountNumber = Customer.GenerateAccountNum()               
            };
            Console.WriteLine("Account Opening Suucessful!");
            Console.WriteLine("Please see your details below: ");
            Console.WriteLine("First Name: " + customer.firstName);
            Console.WriteLine("Last Name: " + customer.lastName);
            Console.WriteLine("Email Address: " + customer.emailAddress);
            Console.WriteLine("Year of Birth: " + customer.birthYear);
            Console.WriteLine("Account Type: " + customer.accountType);
            Console.WriteLine("Account Number: " + customer.accountNumber);
            Console.WriteLine("Date of creation: " + DateTime.Now);
            
            var newcus = customer.firstName + "|";
            Customers.Add(customer);
        }       
        public static void LoginAccount()
        {
            Console.WriteLine("Please enter your birth year: ");
            int userBirthYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your account number: ");
            int userAccountNum = Convert.ToInt32(Console.ReadLine());

            foreach (var i in Customers)
            {
                if(userBirthYear == i.birthYear && userAccountNum == i.accountNumber)
                {
                    Console.WriteLine("Login Successful!");
                }
            }
        }
    }
}
