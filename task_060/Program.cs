// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

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