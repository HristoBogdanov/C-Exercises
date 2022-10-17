using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basein
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert R and H with 1 interval in between:");
            string st = Console.ReadLine();
            var pom = st.Split(' ').ToList();

            Console.WriteLine("Insert price for 1 cubic meter and tax/100 with one interval space in between:");
            string st1 = Console.ReadLine();
            var pom1 = st1.Split(' ').ToList();

            pool p = new pool(double.Parse(pom[0]), double.Parse(pom[1]));
            Console.WriteLine($"The volume of the pool is {Math.Round(p.V(),2)}");
            Console.WriteLine($"The price for water is {Math.Round(p.Price_water(double.Parse(pom1[0]),double.Parse(pom[1])),2)}lv.");
        }
    }
}
