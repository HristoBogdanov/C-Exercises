using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_acc.Models
{
    public class Person
    {
        private string name;
        private int age;

        public List<BankAcc> Accounts { get; set; }
        
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public Person()
        {

        }
        public double GetBalance()
        {
            double sum = 0;
            foreach (BankAcc x in Accounts) sum += x.Balance;
            return sum;
        }
        public override string ToString()
        {
            return $"{this.Name} -- {this.Age} -- {this.GetBalance()}";
        }
    }
}
