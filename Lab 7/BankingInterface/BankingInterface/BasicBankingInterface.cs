using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingInterface
{
    interface BasicBankingInterface
    {
        bool deposit(int amount);
        bool withdraw(int amount);
    }
}
