using System;
using System.Collections.Generic;

List<int> FirstList = new List<int>()
{
    1,4,7,9,15,19,37
};


List<int> SecondList = new List<int>()
{
    2,4,9,23,19,30,31,7
};

List<int> Intersection = new List<int>();
List<int> DifferenceFirst = new List<int>();
List<int> DifferenceSecond = new List<int>();


for (int i = 0; i < FirstList.Count; i++)
{
    for (int j = 0; j < SecondList.Count; j++)
    {
        if (FirstList[i] == SecondList[j])
        {
            Intersection.Add(SecondList[j]);
        }
    }

}
for (int i = 0; i < FirstList.Count; i++)
{
    if (!SecondList.Contains(FirstList[i]))
    {
        DifferenceFirst.Add(FirstList[i]);
    }
}

for (int i = 0; i < SecondList.Count; i++)
{
    if (!FirstList.Contains(SecondList[i]))
    {
        DifferenceSecond.Add(SecondList[i]);
    }
}


Console.WriteLine("Intersection of First and Second List");
Console.WriteLine(String.Join(", ", Intersection));

Console.WriteLine("Difference of FirstList with SecondList");
Console.WriteLine(String.Join(", ",DifferenceFirst));

Console.WriteLine("Difference of SecondList with FirstList");
Console.WriteLine(String.Join(", ", DifferenceSecond));

