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



Console.WriteLine("Let's create two matrixes and I will find it's resulting multiplication matrix.");
Console.WriteLine("Enter matrix's 1 length - rows");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter matrix's 1 length - columns");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Enter matrix's 2 length - rows");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter matrix's 2 length - columns");
int n2 = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = new int[m1, n1];
int[,] matrix2 = new int[m2, n2];

Console.WriteLine();
Console.WriteLine("Your matrix1 is: ");
Console.WriteLine();
FillMatrixWRandom(matrix1, m1, n1);
Console.WriteLine();
Console.WriteLine("Your matrix2 is: ");
Console.WriteLine();
FillMatrixWRandom(matrix2, m2, n2);
Console.WriteLine();
Console.WriteLine("Your resulting multiplication matrix is: ");
Console.WriteLine();

int m3 = m1;
int n3 = n2;
int[,] matrix3 = new int[m3, n3];

if (n1 != m2)
{
    Console.WriteLine("Multiplication of matrixes is not possible!");
}
else
{
    // matrix3[0, 0] = (matrix1[0, 0] * matrix2[0, 0]) + (matrix1[0, 1] * matrix2[1, 0]); 
    // matrix3[0, 1] = (matrix1[0, 0] * matrix2[0, 1]) + (matrix1[0, 1] * matrix2[1, 1]);
    // matrix3[1, 0] = (matrix1[1, 0] * matrix2[0, 0]) + (matrix1[1, 1] * matrix2[1, 0]); 
    // matrix3[1, 1] = (matrix1[1, 0] * matrix2[0, 1]) + (matrix1[1, 1] * matrix2[1, 1]);

    for (int i = 0; i < m3; i++)
    {
        for (int j = 0; j < n3; j++)
        {
            matrix3[i, j] = 0;

            for (int k = 0; k < n1; k++)
            {
                matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
}

PrintMatrix(matrix3);
Console.WriteLine();

