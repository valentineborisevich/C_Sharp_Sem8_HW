// Дополнительные задачи(необязательные):

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillMatrixWRandom(int[,] matrix, int rowslength, int columnslength)
{
    for (int i = 0; i < rowslength; i++)
    {
        for (int j = 0; j < columnslength; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Enter matrix's length - rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter matrix's length - columns");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

Console.WriteLine("Your matrix is: ");
Console.WriteLine();
FillMatrixWRandom(matrix, m, n);
