using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masivi_zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7];
            Random r = new Random();
            int number = int.Parse(Console.ReadLine());
            for(int i=0;i<arr.Length-1;i++)
            {
                arr[i] = r.Next(1, 99);
            }
            arr[6] = number;

            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i]>arr[j])
                    {
                        int pom = arr[i];
                        arr[i] = arr[j];
                        arr[j] = pom;
                    }
                }
            }
            foreach (int x in arr) Console.WriteLine(x);
        }
    }
}
