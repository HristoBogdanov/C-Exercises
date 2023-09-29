using System;
using System.Linq;

int n = int.Parse(Console.ReadLine());
if(n<3 || n>10)
{
    Console.WriteLine("You entered invalid size!");
    return;
}

char[,] maze = new char[n, n];
for (int i = 0; i < n; i++)
{
    string row = Console.ReadLine();
    for (int j = 0; j < n; j++)
    {
        maze[i, j] = row[j];
    }
}

int[] startCoordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
int startRow = startCoordinates[0]-1;
int startCol = startCoordinates[1]-1;

int roomCell = CountRoomCells(maze, startRow, startCol);

Console.WriteLine($"The room has a size of {roomCell}.");

static int CountRoomCells(char[,] maze, int row, int col)
{

    if (row < 0 || row >= maze.GetLength(0) || col < 0 || col >= maze.GetLength(1) || maze[row, col] == '*')
    {
            return 0;
    }

    maze[row, col] = '*';

    int count = 1;
    count += CountRoomCells(maze, row - 1, col);     
    count += CountRoomCells(maze, row, col - 1);     
    count += CountRoomCells(maze, row, col + 1);     
    count += CountRoomCells(maze, row + 1, col);     

    return count;

}