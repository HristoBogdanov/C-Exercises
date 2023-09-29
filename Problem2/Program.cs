using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Please enter a list of integers, each separated by one interval:");

List<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

for (int i = 0; i < numbers.Count-1; i++)
{
    if (numbers[i] + numbers[i+1]==5)
    {
        numbers.RemoveRange(i,2);
        Console.WriteLine($"Removed elements at indexes {i} and {i+1}");
        Console.WriteLine("The list now looks like this:");
        Console.WriteLine(String.Join(", ", numbers));
    }
}
