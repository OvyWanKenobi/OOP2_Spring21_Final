using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab1
{
        abstract class Account
        {
            public string AccID { get; set; }
            public string AccName { get; set; }
            public double Balance { get; set; }

            public Account() { }
            public Account(string accId, string accName, double accBalance)
            {
                AccID = accId;
                AccName = accName;
                Balance = accBalance;
            }

            public void Deposit(double amount)
            {
                Balance += amount;
                Console.WriteLine("your account is deposited by {0}. Current balance: {1}", amount, Balance);
            }

            public  void Withdraw(double amount)
             {
            if (amount < Balance)
            {
                Balance -= amount;
                Console.WriteLine("Your account debited by {0}", amount);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
             }

        public void Transfer(Account acc, double amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                acc.Balance += amount;
                Console.WriteLine("your account transfer by amount {0} to the account {1}({2})", amount, acc.AccName, acc.AccNo);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

        public void ShowInfo()
            {
                
            }

        }
    }
