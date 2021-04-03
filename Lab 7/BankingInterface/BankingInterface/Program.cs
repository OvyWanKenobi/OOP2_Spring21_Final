using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Current ca = new Current();
            Savings sa = new Savings();
            Overdraft oa = new Overdraft();

            Console.WriteLine();
            Console.WriteLine("<<Testing Current Account>>");
            Console.WriteLine();
            ca.balance = 1000;
            ca.deposit(1000);
            ca.withdraw(500);

            Console.WriteLine();
            Console.WriteLine("<<Testing Saving Account>>");
            Console.WriteLine();
            sa.balance = 1000;
            sa.deposit(1000);
            sa.withdraw(500);
            sa.withdraw(1000);
            sa.deposit(1500);
            sa.withdraw(1900);

            Console.WriteLine();
            Console.WriteLine("<<Testing Overdraft Account>>");
            Console.WriteLine();
            oa.balance = 1000;
            oa.overdraftlimit = 500;
            oa.deposit(1000);
            oa.withdraw(2200);
            oa.withdraw(400);
            oa.deposit(2000);
            oa.withdraw(3500);


        }
    }
}
