/*
Задача 54: Задайте двумерный массив. 
Напишите программу, которая 
упорядочит по убыванию элементы 
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int [,] CreateArray(int row, int col, int min, int max){ 
    Random rand = new Random(); 
    int [,] array = new int [row,col]; 
    for (int i = 0; i < row; i++) 
    { 
        for (int j = 0; j < col; j++) 
        { 
            array[i,j] = rand.Next(min,max+1); 
        } 
    } 
    return array; 
} 

void PrintArray(int [,] array){ 
    int row = array.GetLength(0); 
    int col = array.GetLength(1); 
    for (int i = 0; i < row; i++) 
    { 
        for (int j = 0; j < col; j++) 
        { 
            Console.Write($"{array [i,j]}\t"); 
        } 
        Console.WriteLine(); 
    } 
} 

int[,] SortDigitMinToBig(int[,] array)
{
    int[,] array2 = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
        {
            int[] row = new int[array.GetLength(1)];
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    row[j] = array[i, j];
                }
            Array.Sort(row);
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    array2[i, j] = row[j];
                }
        }

    return array2;
}

int[,] SortDigitBigToMin(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        int maxIndex = 0;
        for (int j = 1; j < cols; j++)
        {
            if (array[i, j] > array[i, maxIndex])
            {
                 maxIndex = j;
            }
        }
    
        int temp = array[i, maxIndex];
        for (int j = maxIndex; j > 0; j--)
        {
        array[i, j] = array[i, j - 1];
        }
        array[i, 0] = temp;
    }
    return array;
}



Console.Clear(); 
int [,] array = CreateArray(5,5,0,10); 
PrintArray(array); 
Console.WriteLine(); 
array = SortDigitMinToBig(array);
PrintArray(array);
Console.WriteLine();
array = SortDigitBigToMin(array);
PrintArray(array);
