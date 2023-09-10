int[,] matrix = new int[4, 4];

int number = 1;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i == 0)
        {
            matrix[i, j] = number;
            number += 1;
        }
        if (i > 0 && i < 3 && j == 3)
        {
            matrix[i, matrix.GetLength(0) - 1] = number;
            number += 1;
        }
    }
    if (i == 3)
    {
        for (int k = matrix.GetLength(0) - 1; k >= 0; k--)
        {
            matrix[i, k] = number;
            number++;
        }
    }
}
for (int i = matrix.GetLength(0) - 1; i > 0; i--)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i > 0 && j == 0 && i != 3)
        {
            matrix[i, j] = number;
            number++;
        }
        if (i == 1 && j > 0 && j != 3)
        {
            matrix[i, j] = number;
            number++;
        }
    }
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = matrix.GetLength(0) - 1; j > 0; j--)
    {
        if (i == 2 && j <= 2 && j  > 0)
        {
            matrix[i,j] = number;
            number++;
        }
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        System.Console.Write(matrix[i, j] + " ");
    }
    System.Console.WriteLine();
}


