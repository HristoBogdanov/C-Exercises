using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_acc.Models;
using Bank_acc.Views;
using Bank_acc.Controllers;

namespace Bank_acc
{
    class Program
    {
        static void Main(string[] args)
        {
            ControllerPerson controllerperson = new ControllerPerson();
            controllerperson.Start();
            controllerperson.Work();
        }
    }
}
