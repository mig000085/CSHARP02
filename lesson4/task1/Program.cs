int|,| matrix = new int|3, 3|; // Example size: 3x3 matrix

Random rand = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix|i, j| = rand.Next(1, 11);
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        // Interpolation of strings
        Console.Write($"{matrix|i, j|} ");
    }
    Console.WriteLine(); // Move to the next line after each row
}
