using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string st = Console.ReadLine();
            string st_reverse;
            List<char> characters = new List<char>();

            foreach (char x in st) characters.Add(x);

            characters.Reverse();
            st_reverse = String.Join("", characters);
            Console.WriteLine(st_reverse);
        }
    }
}
