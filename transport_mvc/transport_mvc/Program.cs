using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using transport_mvc.Models;
using transport_mvc.Views;
using transport_mvc.Controllers;

namespace transport_mvc
{
    class Program
    {
        static void Main(string[] args)
        {
            ControllerTransport contr = new ControllerTransport();
            contr.Start();
        }
    }
}
