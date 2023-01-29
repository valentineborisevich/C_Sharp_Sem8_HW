// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void Fill3DMatrixWRandomAndPrint(int[,,] matrix,int arraysnumber, int rowslength, int columnslength)
{
    for (int i = 0; i <arraysnumber; i++)//matrix.GetLength(2)
    {
        for (int j = 0; j < rowslength; j++)//matrix.GetLength(0)
        {
            for (int k = 0; k < columnslength; k++)//matrix.GetLength(1)
            {
            matrix[i, j, k] = new Random().Next(10, 99);
            Console.Write($"{matrix[i, j, k]}({j},{k},{i}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Enter matrixes quantity");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter matrix's length - rows");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter matrix's length - columns");
int o = Convert.ToInt32(Console.ReadLine());

int[,,] matrix = new int[m, n, o];

Console.WriteLine("Your 3D matrix is: ");
Console.WriteLine();
Fill3DMatrixWRandomAndPrint(matrix, m, n, o);