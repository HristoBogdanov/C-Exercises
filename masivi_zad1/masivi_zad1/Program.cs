using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masivi_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();

            string input = Console.ReadLine();

            while(input!="end")
            {
                if (words.Contains(input)) Console.WriteLine("The word is already in! Enter something else!");
                else words.Add(input);

                input = Console.ReadLine();
            }

            words = words.OrderByDescending(q => q).ToList();

            foreach (string x in words) Console.WriteLine(x);
        }
    }
}
