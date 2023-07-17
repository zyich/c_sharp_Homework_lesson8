/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] FillArray(int n)
    {
        int[,] matrix = new int[n, n];

        int top = 0;
        int bottom = n - 1;
        int left = 0;
        int right = n - 1;
        int value = 1;

        while (value <= n * n)
        {
            
            for (int i = left; i <= right; i++)
            {
                matrix[top, i] = value++;
            }
            top++;

            for (int i = top; i <= bottom; i++)
            {
                matrix[i, right] = value++;
            }
            right--;

            for (int i = right; i >= left; i--)
            {
                matrix[bottom, i] = value++;
            }
            bottom--;

            for (int i = bottom; i >= top; i--)
            {
                matrix[i, left] = value++;
            }
            left++;
        }

        return matrix;
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
int [,] array = FillArray(10); 
PrintArray(array); 
Console.WriteLine(); 


