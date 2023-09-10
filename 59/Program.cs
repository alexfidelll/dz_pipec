// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку 
// и столбец, на пересечении которых расположен наименьший элемент массива.

int[,] matrix = new int[,] {{1, 4 ,7 ,2},
                            {5, 9 ,2 ,3},
                            {8 ,4 ,2 ,4},
                            {5 ,2 ,6 ,7}};
SearchNumberOfArray(matrix, 3);

void SearchNumberOfArray(int[,] array, int number)
{
    int lenth = 0;
    int width = 0;


    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (number == array[i, j])
            {
                if (number == array[i, j])
                {
                    lenth = i;
                    width = j;
                }
            }
        }
    }

    int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == lenth){}
        else
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (width == j){}
                else
                {
                 newArray[i,j] = array[i,j];
                 System.Console.Write(newArray[i,j] + " ");
                }
            }
            System.Console.WriteLine();
        }
    }
}
