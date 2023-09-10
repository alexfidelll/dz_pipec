using System.Runtime.InteropServices;

int[,] MathProductMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[2, 2];
int length = 1;

for (int i = 0; i < matrixC.GetLength(0); i++)
{
    matrixC[i,i] = matrixA[i,i]* matrixB[i,i] + matrixA[i,length] * matrixB[length,i];
    matrixC[i, length] = matrixA[i, i] * matrixB[i, length] + matrixA[i, length] * matrixB[length, length];
    length--;
}
    return matrixC;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matrixA = {{2, 4},
                   {3, 2}};

int[,] matrixB = {{3, 4},
                   {3, 3}};

int[,] matrixC = MathProductMatrix(matrixA, matrixB);

PrintArray(matrixC);
