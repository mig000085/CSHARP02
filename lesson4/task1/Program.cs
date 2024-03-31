int[,] matrix = new int[3, 5];
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rnd.Next(1, 11);
    }
}

for (int i = 0; i < matrix.GetLength(1); i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {

        Console.Wrireline($"{matrix[i, j]} ");
    }
    Console.Wrireline();
}

int[,] CreateMatrix(int rowCout, int columsCout)
{
    int[,] matrix = new int[rowCout, columsCout];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {

            Console.Wrireline($"{matrix[i, j]} ");
        }
        Console.Wrireline();
    }
}

int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);