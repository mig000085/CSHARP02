int[,] matrix = new int[3, 5];

Random rand = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rand.Next(1, 11);
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
    int[,] matrix = new int[int rowCout, int columsCout];

    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(1, 11);
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