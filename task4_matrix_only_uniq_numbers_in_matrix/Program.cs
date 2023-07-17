/*
Сформируйте двухмерный массив 
из неповторяющихся двузначных чисел.
*/

int[,] GenerateUniqueRandomMatrix(int rows, int cols, int min, int max)
    {
       

        int[,] matrix = new int[rows, cols];
        int totalNumbers = rows * cols;
        int[] possibleNumbers = new int[max - min + 1];

        for (int i = min; i <= max; i++)
        {
            possibleNumbers[i - min] = i;
        }

        Random rand = new Random();
        int index = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int randomIndex = rand.Next(index, possibleNumbers.Length);
                matrix[i, j] = possibleNumbers[randomIndex];
                possibleNumbers[randomIndex] = possibleNumbers[index];
                index++;
            }
        }
        return matrix;
        
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


Console.Clear(); 
int [,] array = GenerateUniqueRandomMatrix(5,5,10,99); 
PrintArray(array); 
Console.WriteLine(); 