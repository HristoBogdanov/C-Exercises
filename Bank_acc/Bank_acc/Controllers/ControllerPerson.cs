using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_acc.Models;
using Bank_acc.Views;

namespace Bank_acc.Controllers
{
    public class ControllerPerson
    {
        private Person person;
        private Display display;

        public ControllerPerson()
        {
            person = new Person();
            display = new Display();
        }

        public void Start()
        {
            person.Name = display.Name;
            person.Age = display.Age;
            person.Accounts = display.smetki;
        }
        public void Work()
        {
            display.DepositORWithdraw();

            display.PrintView(person);
        }
    }
}

