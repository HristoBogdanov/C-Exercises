int[,] matrix = new int[3, 3];

matrix[0, 0] = 0;
matrix[0, 1] = 1;
matrix[0, 2] = 2;
matrix[1, 0] = 3;
matrix[1, 1] = 4;
matrix[1, 2] = 5;
matrix[2, 0] = 6;
matrix[2, 1] = 7;
matrix[2, 2] = 8;

static void Transpone(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = i+1; j < matrix.GetLength(1); j++)
		{
			int temp=matrix[i,j];
			matrix[i,j]=matrix[j,i];
			matrix[j,i]=temp;
		}
	}
}