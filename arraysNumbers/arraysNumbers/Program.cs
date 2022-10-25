using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arrThree = new List<int>();

            List<int> arrOne = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> arrTwo = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < arrOne.Count; i++)
            {
                for (int j = 0; j < arrTwo.Count; j++)
                {
                    if (arrOne[i] == arrTwo[j]) arrThree.Add(arrTwo[j]);
                }
            }
            Console.WriteLine(string.Join(" ",arrThree));
        }
    }
}
