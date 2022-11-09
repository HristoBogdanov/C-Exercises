using System;

namespace KSI___Masivi_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10] { 4, 6, 3, 7, 3, 2, 6, 1, 7, 4 };

            //метод на мехурчето

            /*for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length-1; j++)
                {
                    if (a[j] < a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }*/



            //метод на пряката селекция

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }

            int turseno_chislo = int.Parse(Console.ReadLine());

           //двоично търсене в сортиран масив

            static object BinarySearchDisplay(int[] arr, int key)
            {
                int minNum = 0;
                int maxNum = arr.Length - 1;

                while (minNum <= maxNum)
                {
                    int mid = (minNum + maxNum) / 2;
                    if (key == arr[mid])
                    {
                        return ++mid;
                    }
                    else if (key < arr[mid])
                    {
                        maxNum = mid - 1;
                    }
                    else
                    {
                        minNum = mid + 1;
                    }
                }
                return "None";
            }
            Console.WriteLine(BinarySearchDisplay(a, turseno_chislo));
        }
    }
}
