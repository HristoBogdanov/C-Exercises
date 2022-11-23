using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace regexExercises
{
    class Program
    {
       public static bool AlmostOnlyLetters(string word)
        {
            Regex pattern = new Regex(@"^[0-9 a-zA-z\.]+");
            Match match = pattern.Match(word);

            return match.Success;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(AlmostOnlyLetters(Console.ReadLine()));      
        }
    }
}
