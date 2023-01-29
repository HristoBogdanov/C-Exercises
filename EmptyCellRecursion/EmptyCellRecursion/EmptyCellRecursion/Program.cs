using System;
using System.Linq;

class MainClass
{
    public static void Main(string[] args)
    {
        // Get the size of the matrix
        int n = int.Parse(Console.ReadLine());

        // Create the matrix
        char[,] matrix = new char[n, n];
        for (int i = 0; i < n; i++)
        {
            string row = Console.ReadLine();
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = row[j];
            }
        }

        // Get the starting point
        int[] start = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int startRow = start[0] - 1;
        int startCol = start[1] - 1;

        // Call the function to get the number of empty cells reachable from the starting point
        int emptyCells = CountEmptyCells(matrix, startRow, startCol);

        // Print the result
        Console.WriteLine(emptyCells);
    }

    // Function to count the number of empty cells reachable from a given point
    public static int CountEmptyCells(char[,] matrix, int row, int col)
    {
        // Base case: if the point is not empty or is out of bounds, return 0
        if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1) || matrix[row, col] == '*')
        {
            return 0;
        }

        // Mark the point as visited
        matrix[row, col] = '*';

        // Recursively count the number of empty cells in the 4 directions around the point
        int count = 1;
        count += CountEmptyCells(matrix, row - 1, col);     // top
        count += CountEmptyCells(matrix, row, col - 1);     // left
        count += CountEmptyCells(matrix, row, col + 1);     // right
        count += CountEmptyCells(matrix, row + 1, col);     // bottom

        return count;
    }
}