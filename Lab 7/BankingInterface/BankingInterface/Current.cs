using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingInterface
{
   
        class Current : BasicBankingInterface
        {
            public Current()  {  }

            public int balance { get; set; }
            public bool deposit(int amount)
            {
                balance = balance + amount;
                Console.WriteLine("Deposited {0}. Current Balance : {1}", amount, balance);
                return true;
            }

            public bool withdraw(int amount)
            {
                if (balance < amount)
                {
                    Console.WriteLine("Insufficient Balance!");
                    return false;
                }
                else
                {
                    balance = balance - amount;
                    Console.WriteLine("Withdrawn {0} from account. Current Balance : {1}", amount, balance);

                    return true;
                }
            }
        }
    
}
