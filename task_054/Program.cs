
// void BubbleSort(int[,]matrix)
// {
//     for (int i = m * n - 1; i > 0; i--)
// {
//     for (int j = 0; j < i; j++)
//         if (matrix[j / n, j % n] > matrix[i / n, i % n])
//         {
//             int x = matrix[j / n, j % n];
//             matrix[j / n, j % n] = matrix[i / n, i % n];
//             matrix[i / n, i % n] = x;
//         }
// }
// }

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void FillMatrixWRandom(int[,] matrix, int rowslength, int columnslength)
{
    for (int i = 0; i < rowslength; i++)
    {
        for (int j = 0; j < columnslength; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void DecliningSort(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int temp;
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        for (int k = j + 1; k < matrix.GetLength(1); k++)
        {
            if (matrix[i, j] < matrix[i, k])
            {
                temp = matrix[i, j];
                matrix[i, j] = matrix[i, k];
                matrix[i, k] = temp;
            }
        }
    }
}
}

Console.WriteLine("Create the matrix and I sort the elements of each row from max to min value");
Console.WriteLine("Enter matrix's length - rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter matrix's length - columns");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

Console.WriteLine("Your matrix is: ");
Console.WriteLine();
FillMatrixWRandom(matrix, m, n);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Your sorted matrix is: ");
Console.WriteLine();
DecliningSort(matrix);
PrintMatrix(matrix);

