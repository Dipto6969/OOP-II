using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem1
{
    internal class BankAccount
    {
        private int accNo;
        private string name;
        private string branchName;
        private double balance;


        public void deposit(double amount)
        {
            balance += amount;
        }
        public bool withdraw(int amount)
        {
            if (balance > amount)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public double getBalance()
        {
          return balance;
        }
    }
}
