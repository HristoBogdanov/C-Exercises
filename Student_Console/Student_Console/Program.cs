using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Stipendiant> stipendianti = new List<Stipendiant>();
            for (int i = 0; i < n; i++)
            {
                List<int> ocenki = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                string name = Console.ReadLine();
                double income = double.Parse(Console.ReadLine());
                Stipendiant stipendiant = new Stipendiant(name, ocenki, income);
                stipendianti.Add(stipendiant);
            }
        }
    }
}
