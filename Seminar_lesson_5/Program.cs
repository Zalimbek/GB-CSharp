// Написать программу, которая задаст двумерный массив,и найти все элементы, у которых все индексы четные 
// заменит эти элементы на их квадраты 

// using System.ComponentModel.DataAnnotations;
// using System.Data;
// using System.Data.Common;

// int[,] CreateMatrix(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     for (int i = 1; i < rows; i++)
//     {
//         for (int j = 1; j<columns; j++)
//         {
//             matrix[i, j] = new Random().Next(min, max+1);

//         }
//     } return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i< matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j< matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i,j]+ " ");
//         }
//         System.Console.WriteLine();
//     }

// }

// void EvenSquares(int[,] matrix)
// {
//     for (int i = 1; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 1; j< matrix.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 matrix[i, j] = matrix[i,j] * matrix[i, j];
//             }
//         }
//     }
// }

// System.Console.WriteLine("Input num of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input num of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value: ");
// int min =  Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value: ");
// int max =  Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateMatrix(rows, columns, min, max);
// PrintMatrix(array);

// EvenSquares(array);
// System.Console.WriteLine();
// PrintMatrix(array);

// Найти сумму элементов на главной диагонали


// using System.ComponentModel.DataAnnotations;
// using System.Data;
// using System.Data.Common;

// int[,] CreateMatrix(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     for (int i = 1; i < rows; i++)
//     {
//         for (int j = 1; j<columns; j++)
//         {
//             matrix[i, j] = new Random().Next(min, max+1);

//         }
//     } return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i< matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j< matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i,j]+ " ");
//         }
//         System.Console.WriteLine();
//     }

// }

// void EvenSquares(int[,] matrix)
// {
//     for (int i = 1; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 1; j< matrix.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 matrix[i, j] = matrix[i,j] * matrix[i, j];
//             }
//         }
//     }
// }

// int MainDiagSum(int[,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum = sum + matrix[i,j];
//             }
//         }
//     } return sum;
// }

// System.Console.WriteLine("Input num of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input num of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value: ");
// int min =  Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value: ");
// int max =  Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateMatrix(rows, columns, min, max);
// PrintMatrix(array);

// System.Console.WriteLine($"The sum of Main Diag elements is: {MainDiagSum(array)}");

//Заполнить двумерный массив, вывести одномерный массив, каждый элемент которого это среднее арифметическое 
// каждой строки

using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Common;

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 1; i < rows; i++)
    {
        for (int j = 1; j<columns; j++)
        {
            matrix[i, j] = new Random().Next(min, max+1);

        }
    } return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i< matrix.GetLength(0); i++)
    {
        for (int j = 0; j< matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j]+ " ");
        }
        System.Console.WriteLine();
    }

}

void EvenSquares(int[,] matrix)
{
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j< matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] = matrix[i,j] * matrix[i, j];
            }
        }
    }
}

int MainDiagSum(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + matrix[i,j];
            }
        }
    } return sum;
}

double[] SrArArray(int[,] matrix)
{
    double sum = 0;
    double[] srArray = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        srArray[i] = sum / matrix.GetLength(1);
        sum = 0; 
    } return srArray;

}

void PrintArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine("Input num of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input num of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value: ");
int min =  Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value: ");
int max =  Convert.ToInt32(Console.ReadLine());

int[,] array = CreateMatrix(rows, columns, min, max);
PrintMatrix(array);
System.Console.WriteLine();

PrintArray(SrArArray(array));

