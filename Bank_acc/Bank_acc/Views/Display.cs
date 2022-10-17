using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_acc.Models;

namespace Bank_acc.Views
{
    public class Display
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Amount { get; set; }
        public int ID { get; set; }
        public List<BankAcc> smetki;
        public Display()
        {
            smetki = new List<BankAcc>();

            GetValue();
        }
        public void GetValue()
        {
            Console.WriteLine("Ime na klienta:");
            this.Name = Console.ReadLine();
            Console.WriteLine("Godini na klienta:");
            this.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete broq na smetkite na klienta:");
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nomer na bankova smetka");
                this.ID = int.Parse(Console.ReadLine());
                BankAcc bank = new BankAcc(this.ID, 50);
                smetki.Add(bank);
            }
        }
        public void DepositORWithdraw()
        {
            Console.Write("Deposit or Withdraw?");
            string st = Console.ReadLine();
            Console.Write($"Suma za {st}?");
            this.Amount = double.Parse(Console.ReadLine());
            Console.Write("V koq pored smetka smetka?");
            int j = int.Parse(Console.ReadLine());
            if (st == "Deposit")
                smetki[j - 1].Deposit(this.Amount);
            else smetki[j - 1].Withdraw(this.Amount);
        }

        public void PrintView(Person person)
        {
            Console.WriteLine(person.ToString());
        }
    }
}
