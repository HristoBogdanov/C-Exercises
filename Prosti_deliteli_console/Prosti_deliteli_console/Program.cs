using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosti_deliteli_console
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            IntegerNumber number = new IntegerNumber(a);

            Console.WriteLine(number.Razlagane());
        }
    }
}
