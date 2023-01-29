// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void LesserSum(int[] array)
{
    int min = array[0];
    int index = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            index = i;
        }
    }
    Console.WriteLine($"Lesser sum row is {index + 1}");
}

Console.WriteLine("Enter matrix's length - rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter matrix's length - columns");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

Console.WriteLine("Your matrix is: ");
Console.WriteLine();
FillMatrixWRandom(matrix, m, n);
Console.WriteLine();
Console.WriteLine("Now I'll show lesser sum row");

int[] SumArray = new int[m];
int RowSum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        RowSum += matrix[i, j];
    }
    SumArray[i] = RowSum;
    // Console.WriteLine($"{RowSum}");
    RowSum = 0;
}

Console.WriteLine();
LesserSum(SumArray);

