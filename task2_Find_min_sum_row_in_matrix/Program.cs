/*
Задача 56: Задайте прямоугольный 
двумерный массив. Напишите программу, 
которая будет находить 
строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов 
в каждой строке и выдаёт номер 
строки с наименьшей суммой элементов: 1 строка
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

(int minRow, int minSum) RowWithMinSum(int[,] array)
{
    int numRows = array.GetLength(0);
    int numCols = array.GetLength(1);
    int[] rowSums = new int[numRows];

    for (int i = 0; i < numRows; i++)
    {
        int sum = 0;
        for (int j = 0; j < numCols; j++)
        {
            sum += array[i, j];
        }
        rowSums[i] = sum;
    }

    int minRow = 0;

    for (int i = 1; i < numRows; i++)
    {
        if (rowSums[i] < rowSums[minRow])
        {
            minRow = i;
        }
    }

    return (minRow, rowSums[minRow]);
}

void PrintResult(int minRow, int minSum)
{
    Console.WriteLine($"Row with the minimum sum: {minRow + 1}");
    Console.WriteLine($"Sum of the minimum row: {minSum}");
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


int[,] array = CreateArray(5, 4, 0, 10);
PrintArray(array);
Console.WriteLine();
(int minRow, int minSum) = RowWithMinSum(array);
PrintResult(minRow, minSum);