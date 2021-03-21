using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab1
{
    class Transaction
    {
        public Account Sender {
            get { return sender; }
            set { sender = value; }
        }

        public Account Receiver
        {
            get { return receiver; }
            set { receiver = value; }
        }
  
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string AdditionalInfo
        {
            get { return additionalInfo; }
            set { additionalInfo = value; }
        }


        public Transaction() { }
        public Transaction(Account sender, Account receiver, int amount, string additionalInfo)
        {
           
        }

    }
}
