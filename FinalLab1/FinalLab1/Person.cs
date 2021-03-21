using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab1
{
    class Person
    {
        public string Name { get; set; }
        Account[] accounts;
        public int AccCount { get; set; }
        public Person() { }
        public Person(string name)
        {
            Name = name;
            accounts = new Account[10];
        }
        public void AddAccount(params Account[] accounts)
        {
            foreach (Account acc in accounts)
            {
                this.accounts[AccCount++] = acc;
            }
        }
    }
