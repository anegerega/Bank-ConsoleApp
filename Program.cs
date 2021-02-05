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
            Activities.Menu();
        }        
    }
}
