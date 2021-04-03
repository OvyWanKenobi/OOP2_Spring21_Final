using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingInterface
{
    class Overdraft :BasicBankingInterface
    {
        public Overdraft() { }

        public int balance { get; set; }
        public int overdraftlimit { get; set; }
        public bool deposit(int amount)
        {
            balance = balance + amount;
            return true;
        }

        public bool withdraw(int amount)
        {
            if (amount < balance + overdraftlimit)
            {
                balance = balance - amount;
                Console.WriteLine("Withdrawn {0} from account. Current Balance : {1}", amount, balance);
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient Balance!");
                return false;
            }
        }
    }
}
