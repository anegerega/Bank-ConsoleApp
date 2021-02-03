using System;
using System.Collections.Generic;
using System.Text;
using Bank-ConsoleApp.Models;

namespace Bank-ConsoleApp.Operations
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public static void TransferFunds()
        {

        }
        public static void Withdraw()
        {

        }
        public static void GenerateStatement()
        {

        }
    }
}
