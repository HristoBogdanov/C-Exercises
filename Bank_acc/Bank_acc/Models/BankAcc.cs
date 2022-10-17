using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_acc.Models
{
    public class BankAcc
    {
        private int id;
        private double balance;

        public int ID { get { return this.id; }

            set { this.id = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public BankAcc()
        {
                
        }

        public BankAcc(int id,double balance):this()
        {
            this.ID = id;
            this.Balance = 50;
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (this.Balance >= amount) balance += amount;
            else throw new ArgumentException("Няма достатъчно пари");
        }
        
    }
}
