using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uchashti
{
    class Program
    {

        static void Main(string[] args)
        {
            double min_zapl = double.Parse(Console.ReadLine());
            List<string> degree = new List<string>();
            List<string> name = new List<string>();
            List<string> surname = new List<string>();
            List<string> fac_number = new List<string>();
            List<string> speciality = new List<string>();
            List<Mater> Masters = new List<Mater>();
            List<Bachelor> Bachelors = new List<Bachelor>();
            var line = Console.ReadLine();
            while (line.ToString()!="End")
            {
                int br = 0;
                var pom = line.Split(' ').ToArray();
                degree[br] = pom[0];
                name[br] = pom[1];
                surname[br] = pom[2];
                fac_number[br] = pom[3];
                speciality[br] = pom[4];
                br++;
            }
            for (int i = 0; i < degree.Count; i++)
            {
                if (degree[i] == "master")
                {
                    Console.WriteLine("Insert grade");
                    double sr_uspeh = double.Parse(Console.ReadLine());
                    Mater master = new Mater(sr_uspeh, name[i], surname[i], fac_number[i], speciality[i]);
                    Masters.Add(master);
                }
                else
                {
                    Console.WriteLine("Insert grade:");
                    double sr_uspeh = double.Parse(Console.ReadLine());
                    Bachelor bachelor = new Bachelor(sr_uspeh, name[i], surname[i], fac_number[i], speciality[i]);
                    Bachelors.Add(bachelor);
                }                    
            }
            Console.WriteLine($"Number of masters: {Masters.Count}");
            Console.WriteLine($"Number of bachelors: {Bachelors.Count}");

            for (int i = 0; i < Bachelors.Count; i++)
            {
                Console.WriteLine($"{Bachelors[i].Fac_number} - {Bachelors[i].Name}  {Bachelors[i].Surname} - {Bachelors[i].Speciality} sum: {Bachelors[i].Fee(min_zapl)}");
                if (Bachelors[i].Internship() == "Internship in the educational department")
                {
                    Console.WriteLine($"Internship in the educational department : ");
                    Console.WriteLine($"{Bachelors[i].Name}  {Bachelors[i].Surname}");
                }
            }
            for (int i = 0; i < Masters.Count; i++)
            {
                Console.WriteLine($"{Masters[i].Fac_number} - {Masters[i].Name}  {Masters[i].Surname} - {Masters[i].Speciality} sum: {Masters[i].Fee(min_zapl)}");
                if (Masters[i].Internship() == "Partner Firm")
                {
                    Console.WriteLine($"Partner Firm : ");
                    Console.WriteLine($"{Bachelors[i].Name}  {Bachelors[i].Surname}");
                }
            }
        }
    }
}
