using System;
using System.Collections.Generic;
using System.Text;
using BankSystem.Models;

namespace BankSystem.Operations
{
    class Activities
    {        
        public static void CreateAccount()
        {
            try
            {
                List<Customer> BankCustomers = new List<Customer>();
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
                    accountNumber = Customer.GenerateAccountNum(),
                    balance = 0,
                    dateCreated = DateTime.Now,
                    accountType = AT,                                       
                };
                Console.WriteLine("Account Opening Suucessful!");
                Console.WriteLine("Please see your details below: ");
                Console.WriteLine("First Name: " + customer.firstName);
                Console.WriteLine("Last Name: " + customer.lastName);
                Console.WriteLine("Email Address: " + customer.emailAddress);
                Console.WriteLine("Year of Birth: " + customer.birthYear);
                Console.WriteLine("Account Number: " + customer.accountNumber);
                Console.WriteLine("Date of creation: " + DateTime.Now);

               
                BankCustomers.Add(customer);
                ContinueBanking();
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Menu();
            }
        
        }

        public static void LoginAccount()
        {
            List<Customer> BankCustomers = new List<Customer>();
            Console.WriteLine("Please enter your birth year: ");
            int userBirthYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your account number: ");
            int userAccountNum = Convert.ToInt32(Console.ReadLine());
            
            foreach (var i in BankCustomers)
            {
                if (userBirthYear == i.birthYear && userAccountNum == i.accountNumber)
                {
                    Console.WriteLine("Login Successful!");
                }
            }
        }
        public static string Login(Customer A)
        {
            Console.WriteLine("Login to your account");
            Console.WriteLine("Enter your account number: ");
            int acctNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your email address: ");
            string userEmail = Console.ReadLine();
            Console.WriteLine("Enter your birth year: ");
            if (A.accountNumber == acctNum )
            {

                return ("Successfully Logged in");
            }
            else
            {
                return ("User not found");
            }
        }
        public static void Deposit()
        {

        }
        public static void CheckBalance(Customer A)
        {
           //Login(A);
            try
            {
                Console.WriteLine(A.balance);
                    ContinueBanking();
   
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                ContinueBanking();
            }
        }
        public static void TransferFunds(Customer A, Customer B, int Amt)
        {   
            //Login 

            Console.WriteLine("Enter Sender's account number: ");
            var SenderNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Recipient's account number: ");
            var ReceiverNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount: ");
            Amt = Convert.ToInt32(Console.ReadLine());

            try
            {
                if(A.balance > Amt || A.balance == Amt)
                {
                    A.balance = A.balance - Amt;
                    B.balance = B.balance + Amt;
                }
                if(A.balance < Amt)
                {
                    Console.WriteLine("Insufficient Funds");
                }

                ContinueBanking();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                ContinueBanking();
            }
        }
        public static void Withdraw(Customer A, int Amt)
        {
            Console.WriteLine("Enter Amount: ");
            Amt = Convert.ToInt32(Console.ReadLine());
            if(A.balance > Amt || A.balance == Amt)
            {
                A.balance -= Amt;
                Console.WriteLine("Alert: Your new balance = " + A.balance);
            }
            
            if(A.balance < Amt)
            {
                Console.WriteLine("Sorry, you do not have enough money.");
            }
            ContinueBanking();
            
            //continuing code
        }
        public static void Menu()
        {            
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
                    Activities.CreateAccount();
                    break;
                case "2":
                    Activities.LoginAccount();
                    break;
                case "3":
                    Activities.Deposit();
                    break;
                case "4":
                    ;
                    break;
                case "5":
                    // Activities.TransferFunds(Customer A, Customer B, int Amt);
                    // break;
                    Console.WriteLine("Goodbye");
                    break;
            }
        }
        public static void ContinueBanking()
        {
            Console.WriteLine("Do you want to perform another operation? (Yes/No)");
            string userDecision = Console.ReadLine();
            if(userDecision.ToUpper() == "YES")
            {
                Menu();
            }
            else if(userDecision.ToUpper() == "NO")
            {
                Console.WriteLine("Thank you for banking with us, Goodbye!");
            }
            else
            {
                Console.WriteLine("Please enter \"Yes\" or \"No\"");
                ContinueBanking();
            }
        }
        public static void GenerateStatement()
        {

        }
       
    }
}
