/*
Задача 58: Задайте две матрицы. 
Напишите программу, которая будет 
находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] CreateArray(int row, int col, int min, int max)
{
    Random rand = new Random();
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rand.Next(min, max + 1);
        }
    }
    return array;
}

int[,] Multiplication(int[,] arrayA, int[,] arrayB)
{
    int rowsA = arrayA.GetLength(0);
    int colsA = arrayA.GetLength(1);
    int colsB = arrayB.GetLength(1);

    int[,] result = new int[rowsA, colsB];

    for (int i = 0; i < rowsA; i++)
    {
        for (int j = 0; j < colsB; j++)
        {
            int sum = 0;
            for (int k = 0; k < colsA; k++)
            {
                sum += arrayA[i, k] * arrayB[k, j];
            }
            result[i, j] = sum;
        }
    }

    return result;
}


void PrintArray(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int[,] arrayA = CreateArray(2, 2, 2, 4);
int[,] arrayB = CreateArray(2, 2, 2, 4);

Console.WriteLine("Matrix A:");
PrintArray(arrayA);
Console.WriteLine();
Console.WriteLine("Matrix B:");
PrintArray(arrayB);
Console.WriteLine();

int[,] result = Multiplication(arrayA, arrayB);

Console.WriteLine("Result matrix:");
PrintArray(result);