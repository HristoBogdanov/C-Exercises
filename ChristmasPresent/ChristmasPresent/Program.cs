using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasPresent
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double gift1 = double.Parse(Console.ReadLine());
            double gift2 =Math.Round((0.2 * gift1),2);
            double gift3 = Math.Round((0.7 * gift2), 2);
            double gift4 = Math.Round((0.5 * gift2), 2);

            double result = gift1 + gift2 + gift3 + gift4;

            if (result <= budget) Console.WriteLine($"Yes! {(budget - result):f2} leva left.");
            else Console.WriteLine($"No! {(result-budget):f2} leva needed.");
        }
    }
}
