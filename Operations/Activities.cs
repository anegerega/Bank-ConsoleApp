using System;
using System.Collections.Generic;
using System.Text;
using BankSystem.Models;

namespace BankSystem.Operations
{
    class Activities
    {
        public static void Deposit()
        {

        }
        public static void CheckBalance()
        {
            var customer = new Customer();
            try
            {
                if (customer.balance > 0)
                {
                    var newbalance = customer.balance;
                    
                }
                else
                {
                    Console.WriteLine("Your account is empty");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public static void TransferFunds(Customer A, Customer B)
        {
            var cus1 = new Customer();
            var cus2 = new Customer();
            Console.WriteLine("Enter Sender's account number: ");
            var SenderNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Recipient's account number: ");
            var ReceiverNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount: ");
            var Amt = Convert.ToInt32(Console.ReadLine());

            try
            {
                if(A.balance > B.balance)
                {
                    A.balance = A.balance - Amt;
                }
               
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public static void Withdraw()
        {

        }
        public static void GenerateStatement()
        {

        }
    }
}
