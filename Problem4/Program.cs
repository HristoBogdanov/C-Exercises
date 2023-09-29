using System;

Console.WriteLine("Enter terrain: ");
string terrain = Console.ReadLine();

int countHills = 0;
int countValleys = 0;
int countPlateau = 0;

for (int i = 0; i < terrain.Length-1; i++)
{
    if (terrain[i] == '/' && terrain[i + 1] == '\\')
    {
        countHills++;
    }
    else if (terrain[i] == '\\' && terrain[i + 1] == '/')
    {
        countValleys++;
    }
    else if (terrain[i] == '-' && terrain[i + 1] == '/')
    {
        countValleys++;
    }
    else if (terrain[i] == '-' && terrain[i + 1] == '\\')
    {
        countPlateau++;
    }
}

Console.WriteLine($"Hills: {countHills}");
Console.WriteLine($"Valleys: {countValleys}");
Console.WriteLine($"Plateaus: {countPlateau}");
