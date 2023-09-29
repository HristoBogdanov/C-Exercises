using System;
using System.Collections.Generic;
using System.Linq;

string input = Console.ReadLine();

if(input.Length<2 && input.Length> 100000)
{
    Console.WriteLine("Your text is invalid!");
    return;
}
if(input.Any(c=>c!='(' || c!=')'))
{
    Console.WriteLine("Your text should only contain ( or ) !");
    return;
}

Stack<char> brackets = new Stack<char>();

int openBracketsToRemove = 0;
int closedBracketsToRemove = 0;

foreach (char ch in input)
{
    switch(ch)
    {
        case '(': brackets.Push(ch); 
            break;

        case ')':
            if(brackets.Count > 0)
            {
                brackets.Pop();
            }
            else
            {
                closedBracketsToRemove++;
            }
            break;
    }
}
openBracketsToRemove+=brackets.Count;
if(openBracketsToRemove ==0 && closedBracketsToRemove==0)
{
    Console.WriteLine("The text is valid! There is nothing to remove!");
}
else
{
    Console.WriteLine($"We need to remove {openBracketsToRemove} open brackets and {closedBracketsToRemove} closed brackets.");
}