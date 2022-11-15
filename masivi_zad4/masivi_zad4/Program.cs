using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masivi_zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            int[] arr_result = new int[20];
            Random r = new Random();

            for (int i = 0; i < arr1.Count(); i++)
            {
                arr1[i] = r.Next(1, 100);
                arr2[i] = r.Next(1, 100);
            }

            for (int i = 0; i < arr1.Count(); i++)
            {
                for (int j = 0; j < arr1.Count() - 1; j++)
                {
                    if (arr1[j] > arr1[j + 1])
                    {
                        int pom = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = pom;
                    }
                }
            }

            for (int i = 0; i < arr2.Count(); i++)
            {
                for (int j = i + 1; j < arr2.Count() - 1; j++)
                {
                    if (arr2[i] > arr2[j])
                    {
                        int pom = arr2[i];
                        arr2[i] = arr2[j];
                        arr2[j] = pom;
                    }
                }
            }
            int bonus = 1;          
            int br = 0;
            do
            {
                if (arr1[br] < arr2[br])
                {
                    arr_result[br] = arr1[br];
                    arr_result[br + bonus] = arr2[br];
                }
                else
                {
                    arr_result[br] = arr2[br];
                    arr_result[br + bonus] = arr1[br];
                }

                br++;
                bonus++;
            } while (arr_result[19] == 0);

            foreach (int x in arr_result) Console.WriteLine(x);

        }
    }
}
