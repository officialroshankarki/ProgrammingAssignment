using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class BankAccount
    {
        private string accountNumber;
        private float balance= 0;
        public BankAccount(string accountNumber) {
            this.accountNumber = accountNumber;
            
        }
        public void Deposite(float amount) { 
        float add = amount + balance;
            Console.WriteLine(add);
            Console.WriteLine(accountNumber);
        }
        public void Withdraw(float amount)
        {

        }

    }
}
