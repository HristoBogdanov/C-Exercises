using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unarnost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count of number you are gonna check");
            int broi = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbers:");
           string st = Console.ReadLine();
            List<int> chisla = new List<int>();
            List<int> broi_edinici = new List<int>();
            List<int> pomoshten_list_cifri = new List<int>();
            List<List<int>> cifri_na_chislo = new List<List<int>>();
            List<int> naredeni_chisla = new List<int>();


            string[] NumbersList =st.Split(' ');
            foreach (string x in NumbersList) chisla.Add(int.Parse(x));


            for (int i = 0; i < chisla.Count; i++)
            {
                pomoshten_list_cifri.Clear();
                int pom = chisla[i];
                while(pom>0)
                {
                    pomoshten_list_cifri.Add(pom % 10);
                    pom = pom / 10;                  
                } 
                cifri_na_chislo[i] = pomoshten_list_cifri;
            }
            foreach (int x in cifri_na_chislo[1]) Console.WriteLine(x);


            //foreach (List<int> x in cifri_na_chislo)
            //{
            //for (int i = 0; i < x.Count; i++)
            // {
            //Console.WriteLine(x[i].ToString());
            //}
            //}
            //for (int i = 0; i < cifri_na_chislo.Count; i++)
            //{
            //for (int j = 0; j < cifri_na_chislo[i].Count; j++)
            //{
            //if (cifri_na_chislo[i][j] == 1) broi_edinici[j]++;
            //}
            //}
            //int max = broi_edinici[0];
            //for (int i = 0; i < broi_edinici.Count; i++)
            //{
            //if (broi_edinici[i] > max) max = broi_edinici[i];
            //}
            //Console.WriteLine(max.ToString());
        }
    }
}
