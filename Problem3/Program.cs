using System;
using System.Collections.Generic;
    
    int n = int.Parse(Console.ReadLine());
    int k = int.Parse(Console.ReadLine());
    List<int> circle = new List<int>();
    for (int i = 1; i <= n; i++)
    {
        circle.Add(i);
    }
    int currentIndex = 0;
    while (circle.Count > 1)
    {
        currentIndex = (currentIndex + k - 1) % circle.Count;
        circle.RemoveAt(currentIndex);
    }
    Console.WriteLine("The last person left in the circle is: " + circle[0]);
    

